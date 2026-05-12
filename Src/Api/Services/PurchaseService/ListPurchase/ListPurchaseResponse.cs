namespace Api.Services.PurchaseService.ListPurchase
{
    public class ListPurchaseResponse
    {
        public int Id { get; set; }

        public DateTime PurchaseDate { get; set; }

        public decimal TotalPrice { get; set; }

        public String? NameProducer { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
