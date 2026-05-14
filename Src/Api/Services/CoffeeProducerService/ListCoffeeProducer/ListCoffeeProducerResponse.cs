using Api.Services.Common;

namespace Api.Services.CoffeeProducerService.ListCoffeeProducer
{
    public class ListCoffeeProducerResponse : CoffeeResponsePageable
    {
        public List<DataListCoffeeProducerResponse> Result { get; set; } = new();
    }

    public class DataListCoffeeProducerResponse
    {
        public int Id { get; set; }

        public String FirstName { get; set; } = String.Empty;

        public String? LastName { get; set; }

        public String? DocumentNumber { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
