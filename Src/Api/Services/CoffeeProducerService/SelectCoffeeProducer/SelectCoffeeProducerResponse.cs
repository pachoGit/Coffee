namespace Api.Services.CoffeeProducerService.SelectCoffeeProducer
{
    public class SelectCoffeeProducerResponse
    {
        public List<DataSelectCoffeeProducerResponse> Result { get; set; } = new();
    }

    public class DataSelectCoffeeProducerResponse
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
    }
}