using Infra.Database;
using Microsoft.EntityFrameworkCore;

namespace Api.Services.BatchCoffeeProducerService.ListBatchCoffeeProducer
{
    public class ListBatchCoffeeProducerHandler
    {
        private readonly CoffeeDbContext _context;

        public ListBatchCoffeeProducerHandler(CoffeeDbContext context)
        {
            _context = context;
        }

        public async Task<List<ListBatchCoffeeProducerResponse>> Handle(ListBatchCoffeeProducerRequest request)
        {
            var results = await _context.BatchCoffeeProducer.ToListAsync();

            var response = results
                .Select(result => new ListBatchCoffeeProducerResponse
                {
                    Id = result.Id,
                    ScoreSCA = result.ScoreSCA,
                    ScreenSize = result.ScreenSize,
                    CoffeeVarietyId = result.CoffeeVarietyId,
                    CoffeeTypeId = result.CoffeeTypeId,
                    Humidity = result.Humidity,
                    CoffeProducerId = result.CoffeProducerId,
                    CreatedAt = result.CreatedAt
                })
                .ToList();

            return response;
        }
    }
}