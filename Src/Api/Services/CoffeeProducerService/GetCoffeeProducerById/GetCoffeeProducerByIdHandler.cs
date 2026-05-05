using Infra.Database;
using Microsoft.EntityFrameworkCore;

namespace Api.Services.CoffeeProducerService.GetCoffeeProducerById
{
    public class GetCoffeeProducerByIdHandler
    {
        private readonly CoffeeDbContext _context;

        public GetCoffeeProducerByIdHandler(CoffeeDbContext context)
        {
            _context = context;
        }

        public async Task<GetCoffeeProducerByIdResponse?> Handle(int id)
        {
            var result = await _context.CoffeeProducer.FindAsync(id);

            if (result == null)
            {
                return null;
            }

            return new GetCoffeeProducerByIdResponse
            {
                Id = result.Id,
                FirstName = result.FirstName,
                LastName = result.LastName,
                DocumentNumber = result.DocumentNumber,
                CreatedAt = result.CreatedAt
            };
        }
    }
}