using Domain.Entity;
using Xunit;

namespace Test
{
    public class TestExample
    {
        [Fact]
        public void Say()
        {
            CoffeeProducer producer = new();
            PurchaseBatchCoffee purchase = new();
            producer.Id = 21;

            purchase.Id = 1;
            purchase.Amount = 2.56m;
            purchase.CoffeeMarketPrice = 1095.50m; // Dolares o soles
            purchase.BatchPurchasePrice = 1000.00m; // Dolares o soles
            purchase.ExpectedBatchSellingPrice = 1050.50m; // Dolares o soles
        }
    }
}
