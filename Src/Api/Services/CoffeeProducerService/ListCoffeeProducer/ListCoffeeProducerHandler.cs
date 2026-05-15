using Infra.Database;
using Microsoft.EntityFrameworkCore;

namespace Api.Services.CoffeeProducerService.ListCoffeeProducer
{
    public class ListCoffeeProducerHandler
    {
        private readonly CoffeeDbContext _context;

        public ListCoffeeProducerHandler(CoffeeDbContext context)
        {
            _context = context;
        }

        public async Task<ListCoffeeProducerResponse> Handle(ListCoffeeProducerRequest request)
        {
            var query = _context.CoffeeProducer.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request.Name))
            {
                var nameLower = request.Name.ToLower();
                query = query.Where(p => 
                    p.FirstName.ToLower().Contains(nameLower) || 
                    (p.LastName != null && p.LastName.ToLower().Contains(nameLower)));
            }

            if (!string.IsNullOrWhiteSpace(request.DocumentNumber))
            {
                query = query.Where(p => p.DocumentNumber == request.DocumentNumber);
            }

            var total = await query.CountAsync();

            var results = await query
                .Skip((request.PageNumber - 1) * request.PageSize)
                .Take(request.PageSize)
                .ToListAsync();

            var response = new ListCoffeeProducerResponse
            {
                Result = results.Select(result => new DataListCoffeeProducerResponse
                {
                    Id = result.Id,
                    FirstName = result.FirstName,
                    LastName = result.LastName,
                    DocumentNumber = result.DocumentNumber,
                    CreatedAt = result.CreatedAt
                }).ToList(),
                Total = total,
                PageSize = request.PageSize,
                PageNumer = request.PageNumber,
                TotalPages = (int)Math.Ceiling((double)total / request.PageSize)
            };

            return response;
        }
    }
}

