using Infra.Database;

namespace Api.Services.BatchCoffeeProducerService.DeleteBatchCoffeeProducer
{
    public class DeleteBatchCoffeeProducerHandler
    {
        private readonly CoffeeDbContext _context;

        public DeleteBatchCoffeeProducerHandler(CoffeeDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(int id)
        {
            var batch = await _context.BatchCoffeeProducer.FindAsync(id);

            if (batch == null)
            {
                return false;
            }

            batch.DeleteAt = DateTime.Now;
            await _context.SaveChangesAsync();

            return true;
        }
    }
}