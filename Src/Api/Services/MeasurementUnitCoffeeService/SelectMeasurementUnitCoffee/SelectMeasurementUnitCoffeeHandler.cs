using Infra.Database;
using Microsoft.EntityFrameworkCore;

namespace Api.Services.MeasurementUnitCoffeeService.SelectMeasurementUnitCoffee
{
    public class SelectMeasurementUnitCoffeeHandler
    {
        private readonly CoffeeDbContext _context;

        public SelectMeasurementUnitCoffeeHandler(CoffeeDbContext context)
        {
            _context = context;
        }

        public async Task<SelectMeasurementUnitCoffeeResponse> Handle()
        {
            var results = await _context.MeasurementUnitCoffee
                .OrderBy(m => m.Name)
                .ToListAsync();

            var response = new SelectMeasurementUnitCoffeeResponse
            {
                Result = results.Select(r => new DataSelectMeasurementUnitCoffeeResponse
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