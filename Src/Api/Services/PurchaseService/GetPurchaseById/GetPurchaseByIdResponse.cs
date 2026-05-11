namespace Api.Services.PurchaseService.GetPurchaseById
{
    public class GetPurchaseByIdResponse
    {
        public int Id { get; set; }

        public DateTime PurchaseDate { get; set; }

        public decimal TotalPrice { get; set; }

        public CoffeeProducerGetPurchase CoffeeProducer { get; set; } = null!;

        public List<DetailPurchaseGetPurchase> DetailPurchases { get; set; } = null!;

        public DateTime CreatedAt { get; set; }

        public DateTime UpdateAt { get; set; }
    }

    public class CoffeeProducerGetPurchase
    {
        public int Id { get; set; }

        public String FirstName { get; set; } = String.Empty;

        public String? LastName { get; set; } = null;
    }


    public class DetailPurchaseGetPurchase
    {
        public int Id { get; set; }

        public decimal ScoreSCA { get; set; }

        public decimal ScreenSize { get; set; }

        public decimal Humidity { get; set; }

        public CoffeeVarietyGetPurchase? CoffeeVariety { get; set; } = null;

        public CoffeeTypeGetPurchase CoffeeType { get; set; } = null!;

        public PurchaseBatchGetPurchase? Purchase { get; set; } = null;
    }


    public class CoffeeVarietyGetPurchase
    {
        public int Id { get; set; }

        public String Code { get; set; } = String.Empty;

        public String Name {  get; set; } = String.Empty;
    }

    public class CoffeeTypeGetPurchase
    {
        public int Id { get; set; }

        public String Code { get; set; } = String.Empty;

        public String Name {  get; set; } = String.Empty;
    }


    public class PurchaseBatchGetPurchase
    {
        public int Id { get; set; }

        public MeasurementUnitGetPurchase MeasurementUnit { get; set; } = null!;

        public decimal Amount { get; set; }

        public decimal CoffeeMarketPrice { get; set; }

        public decimal? ExpectedBatchSellingPrice { get; set; } = null;
    }

    public class MeasurementUnitGetPurchase
    {
        public int Id { get; set; }

        public String Code { get; set; } = String.Empty;

        public String Name {  get; set; } = String.Empty;
    }
}
