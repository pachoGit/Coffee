namespace Api.Services.MeasurementUnitCoffeeService.SelectMeasurementUnitCoffee
{
    public class SelectMeasurementUnitCoffeeResponse
    {
        public List<DataSelectMeasurementUnitCoffeeResponse> Result { get; set; } = new();
    }

    public class DataSelectMeasurementUnitCoffeeResponse
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
    }
}