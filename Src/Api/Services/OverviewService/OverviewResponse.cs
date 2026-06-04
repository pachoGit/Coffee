namespace Api.Services.OverviewService
{
    public record OverviewResponse(
        DateTime StartDate,
        DateTime EndDate,
        int TotalProducers,
        int TotalPurchases,
        int TotalBatches,
        int TotalPurchaseBatches,
        decimal TotalAmount,
        decimal TotalKilograms,
        decimal TotalQuintales,
        decimal AveragePerformance,
        decimal AverageHumidity,
        decimal AverageScreenSize,
        int DistinctCoffeeVarieties,
        int DistinctCoffeeTypes
    );
}
