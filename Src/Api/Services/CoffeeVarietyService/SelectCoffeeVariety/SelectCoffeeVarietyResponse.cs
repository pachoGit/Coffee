namespace Api.Services.CoffeeVarietyService.SelectCoffeeVariety
{
    public class SelectCoffeeVarietyResponse
    {
        public List<DataSelectCoffeeVarietyResponse> Result { get; set; } = new();
    }

    public class DataSelectCoffeeVarietyResponse
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
    }
}