namespace Api.Services.PurchaseService.CreatePurchase
{
    public record CreatePurchaseRequest
    {
        public int CoffeeProducerId { get; set; }

        public DateTime PurchaseDate { get; set; }

        public decimal TotalCost { get; set; }

        public List<DetailPurchaseRequest> DetailPurchases = new();
    }

    public record DetailPurchaseRequest
    {
        public decimal ScoreSCA { get; set; }

        public decimal ScreenSize { get; set; }

        public decimal Humidity { get; set; }

        public int? CoffeeVarietyId { get; set; }

        public int CoffeeTypeId { get; set; }

        public PurchaseBatchRequest? PurchaseBatch = null;
    }

    public record PurchaseBatchRequest
    {
        public int MeasurementUnitCoffeeId { get; set; }

        public decimal Amount { get; set; }

        public decimal CoffeeMarketPrice { get; set; }

        public decimal BatchPurchasePrice { get; set; }

        public decimal? ExpectedBatchSellingPrice { get; set; }
    }
}
