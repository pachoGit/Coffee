using Api.Services.Common;

namespace Api.Services.PurchaseService.ListPurchase
{
    public class ListPurchaseResponse : CoffeeResponsePageable
    {
        public List<DataListPurchaseResponse> Result { get; set; } = new();
    }

    public class DataListPurchaseResponse
    {
        public int Id { get; set; }

        public DateTime PurchaseDate { get; set; }

        public decimal TotalPrice { get; set; }

        public String? NameProducer { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
