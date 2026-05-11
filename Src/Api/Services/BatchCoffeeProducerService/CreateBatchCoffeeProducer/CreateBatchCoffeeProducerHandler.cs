using Domain.Entity;
using Infra.Database;

namespace Api.Services.BatchCoffeeProducerService.CreateBatchCoffeeProducer
{
    public class CreateBatchCoffeeProducerHandler
    {
        private readonly CoffeeDbContext _context;

        public CreateBatchCoffeeProducerHandler(CoffeeDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateBatchCoffeeProducerRequest request)
        {
            var batch = new BatchCoffeeProducer
            {
                ScoreSCA = request.ScoreSCA,
                ScreenSize = request.ScreenSize,
                CoffeeVarietyId = request.CoffeeVarietyId,
                CoffeeTypeId = request.CoffeeTypeId,
                Humidity = request.Humidity,
                CoffeeProducerId = request.CoffeProducerId,
                CreatedAt = DateTime.Now,
                UpdateAt = DateTime.Now
            };

            await _context.BatchCoffeeProducer.AddAsync(batch);
            await _context.SaveChangesAsync();

            return batch.Id;
        }
    }
}
