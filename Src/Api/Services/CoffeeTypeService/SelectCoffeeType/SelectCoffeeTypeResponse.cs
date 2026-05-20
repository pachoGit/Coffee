namespace Api.Services.CoffeeTypeService.SelectCoffeeType
{
    public class SelectCoffeeTypeResponse
    {
        public List<DataSelectCoffeeTypeResponse> Result { get; set; } = new();
    }

    public class DataSelectCoffeeTypeResponse
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
    }
}