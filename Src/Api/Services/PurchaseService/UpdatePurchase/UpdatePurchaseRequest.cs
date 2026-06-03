namespace Api.Services.PurchaseService.UpdatePurchase
{
    public record UpdatePurchaseRequest
    {
        public DateTime PurchaseDate { get; set; }

        public decimal TotalCost { get; set; }

        public List<DetailPurchaseUpdateRequest> DetailPurchases { get; set; } = new();
    }

    public record DetailPurchaseUpdateRequest
    {
        public decimal Performance { get; set; }

        public decimal ScreenSize { get; set; }

        public decimal Humidity { get; set; }

        public int? CoffeeVarietyId { get; set; }

        public int CoffeeTypeId { get; set; }

        public PurchaseBatchUpdateRequest? PurchaseBatch { get; set; } = null;
    }

    public record PurchaseBatchUpdateRequest
    {
        public int MeasurementUnitCoffeeId { get; set; }

        public decimal Amount { get; set; }

        public decimal CoffeeMarketPrice { get; set; }

        public decimal BatchPurchasePrice { get; set; }

        public decimal? ExpectedBatchSellingPrice { get; set; }
    }
}
