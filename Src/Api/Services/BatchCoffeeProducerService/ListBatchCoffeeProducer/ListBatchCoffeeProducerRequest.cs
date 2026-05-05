using System.Text.Json.Serialization;

namespace Api.Services.BatchCoffeeProducerService.ListBatchCoffeeProducer
{
    public record ListBatchCoffeeProducerRequest
    {
        public int? PageSize { get; set; }

        public int? PageNumber { get; set; }
    }

    [JsonSerializable(typeof(ListBatchCoffeeProducerRequest))]
    internal partial class ListBatchCoffeeProducerRequestContext : JsonSerializerContext
    {

    }
}