
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Services.CoffeeProducerService.ListCoffeeProducer
{
    public record ListCoffeeProducerRequest
    {
        public int? PageSize { get; set; }

        public int? PageNumber { get; set; }
    }

    [JsonSerializable(typeof(ListCoffeeProducerRequest))]
    internal partial class ListCoffeeProducerRequestContext : JsonSerializerContext
    {

    }
}
