using Infra.Database;
using Microsoft.EntityFrameworkCore;

namespace Api.Services.CoffeeProducerService.SelectCoffeeProducer
{
    public class SelectCoffeeProducerHandler
    {
        private readonly CoffeeDbContext _context;

        public SelectCoffeeProducerHandler(CoffeeDbContext context)
        {
            _context = context;
        }

        public async Task<SelectCoffeeProducerResponse> Handle()
        {
            var results = await _context.CoffeeProducer
                .Where(cp => cp.DeleteAt == null)
                .OrderBy(cp => cp.FirstName)
                .ThenBy(cp => cp.LastName)
                .ToListAsync();

            var response = new SelectCoffeeProducerResponse
            {
                Result = results.Select(r => new DataSelectCoffeeProducerResponse
                {
                    Id = r.Id,
                    FullName = $"{r.FirstName} {r.LastName}".Trim()
                }).ToList()
            };

            return response;
        }
    }
}