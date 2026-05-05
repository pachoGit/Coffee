namespace Api.Services.CoffeeProducerService.GetCoffeeProducerById
{
    public class GetCoffeeProducerByIdResponse
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string? LastName { get; set; }
        public string? DocumentNumber { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}