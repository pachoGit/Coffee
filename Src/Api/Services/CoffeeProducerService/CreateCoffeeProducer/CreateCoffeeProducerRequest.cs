using System.Text.Json.Serialization;

namespace Api.Services.CoffeeProducerService.CreateCoffeeProducer
{
    public record CreateCoffeeProducerRequest
    {
        public String? DocumentNumber { get; set; } = null;

        public String FirstName { get; set; } = String.Empty;

        public String? LastName { get; set; } = null;
    }

    [JsonSerializable(typeof(CreateCoffeeProducerRequest))]
    internal partial class CreateCoffeeProducerRequestContext : JsonSerializerContext
    {

    }
}
