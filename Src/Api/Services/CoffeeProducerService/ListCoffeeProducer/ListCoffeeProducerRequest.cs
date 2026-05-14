using Api.Services.Common;

namespace Api.Services.CoffeeProducerService.ListCoffeeProducer
{
    public record ListCoffeeProducerRequest(
        String? Name,
        String? DocumentNumber,
        int PageSize = 10,
        int PageNumber = 1
    ) : ListPageableRequest(PageSize, PageNumber);
}
