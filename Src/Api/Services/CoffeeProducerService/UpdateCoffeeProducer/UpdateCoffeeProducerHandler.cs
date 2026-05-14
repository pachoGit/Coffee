using Infra.Database;

namespace Api.Services.CoffeeProducerService.UpdateCoffeeProducer
{
    public class UpdateCoffeeProducerHandler
    {
        private readonly CoffeeDbContext _context;

        public UpdateCoffeeProducerHandler(CoffeeDbContext context)
        {
            _context = context;
        }

        public async Task<UpdateCoffeeProducerResponse?> Handle(UpdateCoffeeProducerRequest request)
        {
            var producer = await _context.CoffeeProducer.FindAsync(request.Id);

            if (producer == null)
            {
                return null;
            }

            if (request.FirstName != null) producer.FirstName = request.FirstName;
            if (request.LastName != null) producer.LastName = request.LastName;
            if (request.DocumentNumber != null) producer.DocumentNumber = request.DocumentNumber;
            
            producer.UpdateAt = DateTime.Now;

            await _context.SaveChangesAsync();

            return new UpdateCoffeeProducerResponse
            {
                Id = producer.Id,
                FirstName = producer.FirstName,
                LastName = producer.LastName,
                DocumentNumber = producer.DocumentNumber,
                UpdatedAt = producer.UpdateAt
            };
        }
    }
}
