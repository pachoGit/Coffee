using Infra.Database;
using Microsoft.EntityFrameworkCore;

namespace Api.Services.CoffeeTypeService.SelectCoffeeType
{
    public class SelectCoffeeTypeHandler
    {
        private readonly CoffeeDbContext _context;

        public SelectCoffeeTypeHandler(CoffeeDbContext context)
        {
            _context = context;
        }

        public async Task<SelectCoffeeTypeResponse> Handle()
        {
            var results = await _context.CoffeeType
                .OrderBy(ct => ct.Name)
                .ToListAsync();

            var response = new SelectCoffeeTypeResponse
            {
                Result = results.Select(r => new DataSelectCoffeeTypeResponse
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