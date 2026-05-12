using Infra.Database;
using Microsoft.EntityFrameworkCore;

namespace Api.Services.PurchaseService.ListPurchase
{
    public class ListPurchaseHandler
    {
        private readonly CoffeeDbContext _context;

        public ListPurchaseHandler(CoffeeDbContext context)
        {
            _context = context;
        }

        public async Task<List<ListPurchaseResponse>> Handle(ListPurchaseRequest request)
        {
            var query = _context.PurchaseCoffeeProducer
                .Include(p => p.Producer)
                .AsQueryable();

            if (request.StartDate.HasValue)
            {
                query = query.Where(p => p.PurchaseDate >= request.StartDate.Value);
            }

            if (request.EndDate.HasValue)
            {
                query = query.Where(p => p.PurchaseDate <= request.EndDate.Value);
            }

            if (!string.IsNullOrEmpty(request.NameProducer))
            {
                query = query.Where(p => 
                    (p.Producer.FirstName + " " + p.Producer.LastName).Contains(request.NameProducer));
            }

            if (!string.IsNullOrEmpty(request.StartPrice))
            {
                var startPrice = decimal.Parse(request.StartPrice);
                query = query.Where(p => p.TotalPrice >= startPrice);
            }

            if (!string.IsNullOrEmpty(request.EndPrice))
            {
                var endPrice = decimal.Parse(request.EndPrice);
                query = query.Where(p => p.TotalPrice <= endPrice);
            }

            var results = await query
                .OrderByDescending(p => p.PurchaseDate)
                .Skip((request.PageNumber - 1) * request.PageSize)
                .Take(request.PageSize)
                .ToListAsync();

            var response = results.Select(result => new ListPurchaseResponse
            {
                Id = result.Id,
                PurchaseDate = result.PurchaseDate,
                TotalPrice = result.TotalPrice,
                NameProducer = result.Producer.FirstName + " " + result.Producer.LastName,
                CreatedAt = result.CreatedAt,
                UpdatedAt = result.UpdateAt
            }).ToList();

            return response;
        }
    }
}