namespace Api.Services.CoffeeProducerService.ListCoffeeProducer
{
    public class ListCoffeeProducerResponse
    {
        public String FirstName { get; set; } = String.Empty;

        public String? LastName { get; set; }

        public String? DocumentNumber { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
