using Domain.Entity;
using Infra.Database;
using Microsoft.EntityFrameworkCore;

namespace Api.Services.PurchaseService.UpdatePurchase
{
    public class UpdatePurchaseHandler
    {
        private readonly CoffeeDbContext _context;

        public UpdatePurchaseHandler(CoffeeDbContext context)
        {
            _context = context;
        }

        public async Task<int?> Handle(int id, UpdatePurchaseRequest request)
        {
            var purchase = await _context.PurchaseCoffeeProducer
                .Include(p => p.DetailPurchases)
                    .ThenInclude(d => d.Batch)
                        .ThenInclude(b => b.Purchase)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (purchase == null)
            {
                return null;
            }

            var existingDetails = purchase.DetailPurchases.ToList();
            foreach (var detail in existingDetails)
            {
                if (detail.Batch.Purchase != null)
                {
                    _context.PurchaseBatchCoffee.Remove(detail.Batch.Purchase);
                }
                _context.BatchCoffeeProducer.Remove(detail.Batch);
                _context.DetailPurchaseCoffeeProducer.Remove(detail);
            }

            purchase.PurchaseDate = request.PurchaseDate;
            purchase.TotalPrice = request.TotalCost;
            purchase.UpdateAt = DateTime.UtcNow;

            var batches = request.DetailPurchases.Select(d => new BatchCoffeeProducer
            {
                Performance = d.Performance,
                ScreenSize = d.ScreenSize,
                Humidity = d.Humidity,
                CoffeeVarietyId = d.CoffeeVarietyId,
                CoffeeTypeId = d.CoffeeTypeId,
                CoffeeProducerId = purchase.CoffeeProducerId,
                CreatedAt = DateTime.UtcNow,
                UpdateAt = DateTime.UtcNow
            }).ToList();

            _context.BatchCoffeeProducer.AddRange(batches);
            await _context.SaveChangesAsync();

            for (int i = 0; i < request.DetailPurchases.Count; i++)
            {
                var detailRequest = request.DetailPurchases[i];
                var batch = batches[i];

                var detailPurchase = new DetailPurchaseCoffeeProducer
                {
                    PurchaseCoffeeProducerId = purchase.Id,
                    CoffeeProducerId = purchase.CoffeeProducerId,
                    BatchCoffeeProducerId = batch.Id,
                    CreatedAt = DateTime.UtcNow,
                    UpdateAt = DateTime.UtcNow
                };
                _context.DetailPurchaseCoffeeProducer.Add(detailPurchase);

                if (detailRequest.PurchaseBatch != null)
                {
                    var purchaseBatch = new PurchaseBatchCoffee
                    {
                        MeasurementUnitCoffeeId = detailRequest.PurchaseBatch.MeasurementUnitCoffeeId,
                        Amount = detailRequest.PurchaseBatch.Amount,
                        CoffeeMarketPrice = detailRequest.PurchaseBatch.CoffeeMarketPrice,
                        BatchPurchasePrice = detailRequest.PurchaseBatch.BatchPurchasePrice,
                        ExpectedBatchSellingPrice = detailRequest.PurchaseBatch.ExpectedBatchSellingPrice,
                        BatchCoffeeProducerId = batch.Id,
                        CreatedAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow
                    };
                    _context.PurchaseBatchCoffee.Add(purchaseBatch);
                }
            }

            await _context.SaveChangesAsync();
            return purchase.Id;
        }
    }
}
