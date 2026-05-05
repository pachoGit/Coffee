using Infra.Database;

namespace Api.Services.CoffeeProducerService.DeleteCoffeeProducer
{
    public class DeleteCoffeeProducerHandler
    {
        private readonly CoffeeDbContext _context;

        public DeleteCoffeeProducerHandler(CoffeeDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(int id)
        {
            var producer = await _context.CoffeeProducer.FindAsync(id);

            if (producer == null)
            {
                return false;
            }

            producer.DeleteAt = DateTime.Now;
            await _context.SaveChangesAsync();

            return true;
        }
    }
}