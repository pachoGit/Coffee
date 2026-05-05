using Infra.Database;
using Microsoft.EntityFrameworkCore;

namespace Api.Services.BatchCoffeeProducerService.GetBatchCoffeeProducerById
{
    public class GetBatchCoffeeProducerByIdHandler
    {
        private readonly CoffeeDbContext _context;

        public GetBatchCoffeeProducerByIdHandler(CoffeeDbContext context)
        {
            _context = context;
        }

        public async Task<GetBatchCoffeeProducerByIdResponse?> Handle(int id)
        {
            var result = await _context.BatchCoffeeProducer.FindAsync(id);

            if (result == null)
            {
                return null;
            }

            return new GetBatchCoffeeProducerByIdResponse
            {
                Id = result.Id,
                ScoreSCA = result.ScoreSCA,
                ScreenSize = result.ScreenSize,
                CoffeeVarietyId = result.CoffeeVarietyId,
                CoffeeTypeId = result.CoffeeTypeId,
                Humidity = result.Humidity,
                CoffeProducerId = result.CoffeProducerId,
                CreatedAt = result.CreatedAt
            };
        }
    }
}