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

        public async Task<List<ListCoffeeProducerResponse>> Handle(ListCoffeeProducerRequest request)
        {
            var results = await _context.CoffeeProducer.ToListAsync();

            var response = results
                .Select(result => new ListCoffeeProducerResponse
                        {
                            Id = result.Id,
                            FirstName = result.FirstName,
                            LastName = result.LastName,
                            DocumentNumber = result.DocumentNumber,
                            CreatedAt = result.CreatedAt
                        })
                .ToList();

            return response;
        }
    }
}
