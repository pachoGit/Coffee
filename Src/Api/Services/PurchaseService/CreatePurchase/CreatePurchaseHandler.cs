using Domain.Entity;
using Infra.Database;
using Microsoft.EntityFrameworkCore;

namespace Api.Services.PurchaseService.CreatePurchase
{
    public class CreatePurchaseHandler
    {
        private readonly CoffeeDbContext _context;

        public CreatePurchaseHandler(CoffeeDbContext context)
        {
            _context = context;
        }

        public async Task<CreatePurchaseResponse> Handle(CreatePurchaseRequest request)
        {
            await ValidateProducerAsync(request.CoffeeProducerId);

            var purchase = CreatePurchaseEntity(request);
            await SavePurchaseAsync(purchase);

            var batches = CreateBatches(request.DetailPurchases, request.CoffeeProducerId);
            await SaveBatchesAsync(batches);

            await CreateDetailPurchasesAsync(purchase, request.DetailPurchases, batches);
            await _context.SaveChangesAsync();

            return new CreatePurchaseResponse(purchase.Id);
        }

        private async Task ValidateProducerAsync(int coffeeProducerId)
        {
            var producerExists = await _context.CoffeeProducer
                .AnyAsync(p => p.Id == coffeeProducerId);

            if (!producerExists)
            {
                throw new InvalidOperationException($"CoffeeProducer with id {coffeeProducerId} not found");
            }
        }

        private static PurchaseCoffeeProducer CreatePurchaseEntity(CreatePurchaseRequest request)
        {
            return new PurchaseCoffeeProducer
            {
                PurchaseDate = request.PurchaseDate,
                CoffeeProducerId = request.CoffeeProducerId,
                TotalPrice = request.TotalCost,
                CreatedAt = DateTime.UtcNow,
                UpdateAt = DateTime.UtcNow
            };
        }

        private async Task SavePurchaseAsync(PurchaseCoffeeProducer purchase)
        {
            _context.PurchaseCoffeeProducer.Add(purchase);
            await _context.SaveChangesAsync();
        }

        private List<BatchCoffeeProducer> CreateBatches(List<DetailPurchaseRequest> details, int producerId)
        {
            return details.Select(d => new BatchCoffeeProducer
            {
                ScoreSCA = d.ScoreSCA,
                ScreenSize = d.ScreenSize,
                Humidity = d.Humidity,
                CoffeeVarietyId = d.CoffeeVarietyId,
                CoffeeTypeId = d.CoffeeTypeId,
                CoffeeProducerId = producerId,
                CreatedAt = DateTime.UtcNow,
                UpdateAt = DateTime.UtcNow
            }).ToList();
        }

        private async Task SaveBatchesAsync(List<BatchCoffeeProducer> batches)
        {
            _context.BatchCoffeeProducer.AddRange(batches);
            await _context.SaveChangesAsync();
        }

        private async Task CreateDetailPurchasesAsync(
            PurchaseCoffeeProducer purchase,
            List<DetailPurchaseRequest> details,
            List<BatchCoffeeProducer> batches)
        {
            for (int i = 0; i < details.Count; i++)
            {
                var detailRequest = details[i];
                var batch = batches[i];

                var detailPurchase = new DetailPurchaseCoffeeProducer
                {
                    PurchaseCoffeeProducerId = purchase.Id,
                    CoffeeProducerId = purchase.CoffeeProducerId,
                    BatchCoffeeProducerId = batch.Id,
                    CreatedAt = DateTime.UtcNow,
                    UpdateAt = DateTime.UtcNow
                };

                await _context.DetailPurchaseCoffeeProducer.AddAsync(detailPurchase);

                if (detailRequest.PurchaseBatch != null)
                {
                    var purchaseBatch = CreatePurchaseBatch(detailRequest.PurchaseBatch, batch.Id);
                    await _context.PurchaseBatchCoffee.AddAsync(purchaseBatch);
                }
            }
        }

        private PurchaseBatchCoffee CreatePurchaseBatch(PurchaseBatchRequest request, int batchId)
        {
            return new PurchaseBatchCoffee
            {
                MeasurementUnitCoffeeId = request.MeasurementUnitCoffeeId,
                Amount = request.Amount,
                CoffeeMarketPrice = request.CoffeeMarketPrice,
                BatchPurchasePrice = request.BatchPurchasePrice,
                ExpectedBatchSellingPrice = request.ExpectedBatchSellingPrice,
                BatchCoffeeProducerId = batchId,
                CreatedAt = DateTime.UtcNow,
                UpdateAt = DateTime.UtcNow
            };
        }
    }
}
