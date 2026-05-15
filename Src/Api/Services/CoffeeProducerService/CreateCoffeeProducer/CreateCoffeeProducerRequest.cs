namespace Api.Services.CoffeeProducerService.CreateCoffeeProducer
{
    public record CreateCoffeeProducerRequest
    {
        public String? DocumentNumber { get; set; } = null;

        public String FirstName { get; set; } = String.Empty;

        public String? LastName { get; set; } = null;
    }
}
