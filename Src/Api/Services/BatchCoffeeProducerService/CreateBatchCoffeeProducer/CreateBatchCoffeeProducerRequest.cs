using System.Text.Json.Serialization;

namespace Api.Services.BatchCoffeeProducerService.CreateBatchCoffeeProducer
{
    public record CreateBatchCoffeeProducerRequest
    {
        public decimal ScoreSCA { get; set; }

        public decimal ScreenSize { get; set; }

        public int? CoffeeVarietyId { get; set; }

        public int CoffeeTypeId { get; set; }

        public decimal Humidity { get; set; }

        public int CoffeProducerId { get; set; }
    }

    [JsonSerializable(typeof(CreateBatchCoffeeProducerRequest))]
    internal partial class CreateBatchCoffeeProducerRequestContext : JsonSerializerContext
    {

    }
}