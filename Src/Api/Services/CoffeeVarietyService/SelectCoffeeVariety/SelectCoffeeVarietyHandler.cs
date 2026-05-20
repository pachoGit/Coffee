using Infra.Database;
using Microsoft.EntityFrameworkCore;

namespace Api.Services.CoffeeVarietyService.SelectCoffeeVariety
{
    public class SelectCoffeeVarietyHandler
    {
        private readonly CoffeeDbContext _context;

        public SelectCoffeeVarietyHandler(CoffeeDbContext context)
        {
            _context = context;
        }

        public async Task<SelectCoffeeVarietyResponse> Handle()
        {
            var results = await _context.CoffeeVariety
                .OrderBy(cv => cv.Name)
                .ToListAsync();

            var response = new SelectCoffeeVarietyResponse
            {
                Result = results.Select(r => new DataSelectCoffeeVarietyResponse
                {
                    Id = r.Id,
                    Name = r.Name,
                    Code = r.Code
                }).ToList()
            };

            return response;
        }
    }
}