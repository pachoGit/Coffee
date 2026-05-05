namespace Api.Services.BatchCoffeeProducerService.UpdateBatchCoffeeProducer
{
    public class UpdateBatchCoffeeProducerRequest
    {
        public int Id { get; set; }

        public decimal? ScoreSCA { get; set; }

        public decimal? ScreenSize { get; set; }

        public int? CoffeeVarietyId { get; set; }

        public int? CoffeeTypeId { get; set; }

        public decimal? Humidity { get; set; }

        public int? CoffeProducerId { get; set; }
    }
}