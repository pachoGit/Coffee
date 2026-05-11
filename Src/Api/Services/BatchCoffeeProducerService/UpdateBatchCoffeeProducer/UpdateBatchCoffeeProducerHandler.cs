using Domain.Entity;
using Infra.Database;
using Microsoft.EntityFrameworkCore;

namespace Api.Services.BatchCoffeeProducerService.UpdateBatchCoffeeProducer
{
    public class UpdateBatchCoffeeProducerHandler
    {
        private readonly CoffeeDbContext _context;

        public UpdateBatchCoffeeProducerHandler(CoffeeDbContext context)
        {
            _context = context;
        }

        public async Task<UpdateBatchCoffeeProducerResponse?> Handle(UpdateBatchCoffeeProducerRequest request)
        {
            var batch = await _context.BatchCoffeeProducer.FindAsync(request.Id);

            if (batch == null)
            {
                return null;
            }

            if (request.ScoreSCA.HasValue) batch.ScoreSCA = request.ScoreSCA.Value;
            if (request.ScreenSize.HasValue) batch.ScreenSize = request.ScreenSize.Value;
            if (request.CoffeeVarietyId.HasValue) batch.CoffeeVarietyId = request.CoffeeVarietyId;
            if (request.CoffeeTypeId.HasValue) batch.CoffeeTypeId = request.CoffeeTypeId.Value;
            if (request.Humidity.HasValue) batch.Humidity = request.Humidity.Value;
            if (request.CoffeProducerId.HasValue) batch.CoffeeProducerId = request.CoffeProducerId.Value;

            batch.UpdateAt = DateTime.Now;

            await _context.SaveChangesAsync();

            return new UpdateBatchCoffeeProducerResponse
            {
                Id = batch.Id,
                ScoreSCA = batch.ScoreSCA,
                ScreenSize = batch.ScreenSize,
                CoffeeVarietyId = batch.CoffeeVarietyId,
                CoffeeTypeId = batch.CoffeeTypeId,
                Humidity = batch.Humidity,
                CoffeeProducerId = batch.CoffeeProducerId,
                UpdatedAt = batch.UpdateAt
            };
        }
    }
}