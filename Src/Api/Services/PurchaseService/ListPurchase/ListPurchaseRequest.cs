using Api.Services.Common;

namespace Api.Services.PurchaseService.ListPurchase
{
    public record ListPurchaseRequest(
        DateTime? StartDate,
        DateTime? EndDate,
        String? NameProducer,
        String? StartPrice,
        String? EndPrice,
        int PageSize = 10,
        int PageNumber = 1
    ) : ListPageableRequest(PageSize, PageNumber);
}
