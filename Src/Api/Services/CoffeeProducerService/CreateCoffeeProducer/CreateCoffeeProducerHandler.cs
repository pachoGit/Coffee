using Domain.Entity;
using Infra.Database;

namespace Api.Services.CoffeeProducerService.CreateCoffeeProducer
{
    public class CreateCoffeeProducerHandler
    {
        private readonly CoffeeDbContext _context;

        public CreateCoffeeProducerHandler(CoffeeDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateCoffeeProducerRequest request)
        {
            var producer = new CoffeeProducer
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                DocumentNumber = request.DocumentNumber,
                CreatedAt = DateTime.Now,
                UpdateAt = DateTime.Now
            };

            await _context.CoffeeProducer.AddAsync(producer);
            await _context.SaveChangesAsync();

            return producer.Id;
        }
    }
}
