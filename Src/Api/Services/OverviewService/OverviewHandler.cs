using Infra.Database;
using Microsoft.EntityFrameworkCore;

namespace Api.Services.OverviewService
{
    public class OverviewHandler
    {
        private readonly CoffeeDbContext _context;

        public OverviewHandler(CoffeeDbContext context)
        {
            _context = context;
        }

        public async Task<OverviewResponse> Handle(OverviewRequest request)
        {
            var endDate = request.EndDate ?? DateTime.UtcNow;
            var startDate = request.StartDate ?? endDate.AddYears(-1);

            var totalProducers = await _context.CoffeeProducer.CountAsync();

            var purchaseStats = await _context.PurchaseCoffeeProducer
                .Where(p => p.PurchaseDate >= startDate && p.PurchaseDate <= endDate)
                .GroupBy(p => 1)
                .Select(g => new
                {
                    Count = g.Count(),
                    TotalAmount = g.Sum(p => p.TotalPrice)
                })
                .FirstOrDefaultAsync();

            var batchStats = await _context.DetailPurchaseCoffeeProducer
                .Where(d => d.Purchase.PurchaseDate >= startDate && d.Purchase.PurchaseDate <= endDate)
                .GroupBy(d => 1)
                .Select(g => new
                {
                    TotalBatches = g.Count(),
                    AveragePerformance = g.Average(d => (decimal?)d.Batch.Performance),
                    AverageHumidity = g.Average(d => (decimal?)d.Batch.Humidity),
                    AverageScreenSize = g.Average(d => (decimal?)d.Batch.ScreenSize)
                })
                .FirstOrDefaultAsync();

            var distinctVarieties = await _context.DetailPurchaseCoffeeProducer
                .Where(d => d.Purchase.PurchaseDate >= startDate
                    && d.Purchase.PurchaseDate <= endDate
                    && d.Batch.CoffeeVarietyId != null)
                .Select(d => d.Batch.CoffeeVarietyId)
                .Distinct()
                .CountAsync();

            var distinctCoffeeTypes = await _context.DetailPurchaseCoffeeProducer
                .Where(d => d.Purchase.PurchaseDate >= startDate
                    && d.Purchase.PurchaseDate <= endDate)
                .Select(d => d.Batch.CoffeeTypeId)
                .Distinct()
                .CountAsync();

            var purchaseBatchData = await _context.PurchaseBatchCoffee
                .Where(pb => _context.DetailPurchaseCoffeeProducer.Any(d =>
                    d.BatchCoffeeProducerId == pb.BatchCoffeeProducerId
                    && d.Purchase.PurchaseDate >= startDate
                    && d.Purchase.PurchaseDate <= endDate))
                .Select(pb => new
                {
                    pb.Amount,
                    Code = pb.MeasurementUnitCoffee.Code,
                    Name = pb.MeasurementUnitCoffee.Name
                })
                .ToListAsync();

            decimal totalKg = 0;
            foreach (var pb in purchaseBatchData)
            {
                var factor = MeasurementUnitConverter.ToKilograms(pb.Code, pb.Name);
                totalKg += pb.Amount * factor;
            }

            return new OverviewResponse(
                StartDate: startDate,
                EndDate: endDate,
                TotalProducers: totalProducers,
                TotalPurchases: purchaseStats?.Count ?? 0,
                TotalBatches: batchStats?.TotalBatches ?? 0,
                TotalPurchaseBatches: purchaseBatchData.Count,
                TotalAmount: purchaseStats?.TotalAmount ?? 0m,
                TotalKilograms: Math.Round(totalKg, 4),
                TotalQuintales: Math.Round(totalKg / MeasurementUnitConverter.QUINTAL_KG, 4),
                AveragePerformance: Math.Round(batchStats?.AveragePerformance ?? 0m, 4),
                AverageHumidity: Math.Round(batchStats?.AverageHumidity ?? 0m, 4),
                AverageScreenSize: Math.Round(batchStats?.AverageScreenSize ?? 0m, 4),
                DistinctCoffeeVarieties: distinctVarieties,
                DistinctCoffeeTypes: distinctCoffeeTypes
            );
        }
    }
}
