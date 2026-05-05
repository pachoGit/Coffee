namespace Api.Services.CoffeeProducerService.UpdateCoffeeProducer
{
    public class UpdateCoffeeProducerResponse
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string? LastName { get; set; }
        public string? DocumentNumber { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}