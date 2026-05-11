namespace Api.Services.BatchCoffeeProducerService.GetBatchCoffeeProducerById
{
    public class GetBatchCoffeeProducerByIdResponse
    {
        public int Id { get; set; }

        public decimal ScoreSCA { get; set; }

        public decimal ScreenSize { get; set; }

        public int? CoffeeVarietyId { get; set; }

        public int CoffeeTypeId { get; set; }

        public decimal Humidity { get; set; }

        public int CoffeeProducerId { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}