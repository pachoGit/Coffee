namespace Api.Services.PurchaseService.CreatePurchase
{
    public record CreatePurchaseRequest
    {
        public int CoffeeProducerId { get; set; }

        public DateTime PurchaseDate { get; set; }

        public decimal TotalCost { get; set; }

        public List<BatchCoffeeProducerCreatePurchase> Batches = new();
    }

    public record BatchCoffeeProducerCreatePurchase
    {
        public decimal ScoreSCA { get; set; }

        public decimal ScreenSize { get; set; }

        public int? CoffeeVarietyId { get; set; }

        public int CoffeeTypeId { get; set; }

        public decimal Humidity { get; set; }

        public DetailPurchaseBatchCoffeeProducer? DetailPurchase = null;
    }

    public record DetailPurchaseBatchCoffeeProducer
    {
        public int MeasurementUnitId { get; set; }

        public decimal Amount { get; set; }

        public decimal CoffeeMarketPrice { get; set; }

        public decimal BatchPurchasePrice { get; set; }

        public decimal? ExpectedBatchSellingPrice { get; set; }

        public int BatchCoffeeProducerId { get; set; }
    }
}
