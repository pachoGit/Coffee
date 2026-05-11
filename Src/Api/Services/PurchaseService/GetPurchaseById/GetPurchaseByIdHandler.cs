using Domain.Entity;
using Infra.Database;
using Microsoft.EntityFrameworkCore;

namespace Api.Services.PurchaseService.GetPurchaseById
{
    public class GetPurchaseByIdHandler
    {
        private readonly CoffeeDbContext _coffeeDbContext;

        public GetPurchaseByIdHandler(CoffeeDbContext coffeeDbContext)
        {
            _coffeeDbContext = coffeeDbContext;
        }

        public async Task<GetPurchaseByIdResponse?> Handle(int id)
        {
            var purchase = await GetPurchase(id);

            if (purchase == null)
            {
                return null;
            }

            var response = new GetPurchaseByIdResponse();
            response.Id = purchase.Id;
            response.PurchaseDate = purchase.PurchaseDate;
            response.TotalPrice = purchase.TotalPrice;
            response.CoffeeProducer = GetCoffeeProducer(purchase);
            response.DetailPurchases = GetDetailPurchases(purchase);
            response.CreatedAt = purchase.CreatedAt;
            response.UpdateAt = purchase.UpdateAt;

            return response;
        }

        private async Task<PurchaseCoffeeProducer?> GetPurchase(int id)
        {
            return await _coffeeDbContext
                .PurchaseCoffeeProducer
                .Include(pcp => pcp.Producer)

                .Include(pcp => pcp.DetailPurchases)
                    .ThenInclude(dp => dp.Batch)
                        .ThenInclude(b => b.CoffeeType)

                .Include(pcp => pcp.DetailPurchases)
                    .ThenInclude(dp => dp.Batch)
                        .ThenInclude(b => b.CoffeeVariety)

                .Include(pcp => pcp.DetailPurchases)
                    .ThenInclude(dp => dp.Batch)
                        .ThenInclude(b => b.Purchase)

                .Include(pcp => pcp.DetailPurchases)
                    .ThenInclude(dp => dp.Batch)
                        .ThenInclude(b => b.Purchase)
                            .ThenInclude(p => p!.MeasurementUnitCoffee)

                .FirstOrDefaultAsync(pcp => pcp.Id == id);
        }

        private CoffeeProducerGetPurchase GetCoffeeProducer(PurchaseCoffeeProducer purchase)
        {
            return new CoffeeProducerGetPurchase {
                Id = purchase.Producer.Id,
                FirstName = purchase.Producer.FirstName,
                LastName = purchase.Producer.LastName
            };
        }

        private List<DetailPurchaseGetPurchase> GetDetailPurchases(PurchaseCoffeeProducer purchase)
        {
            List<DetailPurchaseGetPurchase> result = new();
            foreach (var detail in purchase.DetailPurchases)
            {
                result.Add(GetDetailPurchase(detail));
            }
            return result;
        }

        private DetailPurchaseGetPurchase GetDetailPurchase(DetailPurchaseCoffeeProducer detail)
        {
            DetailPurchaseGetPurchase result = new();
            result.Id = detail.Id;
            result.ScoreSCA = detail.Batch.ScoreSCA;
            result.ScreenSize = detail.Batch.ScreenSize;
            result.Humidity = detail.Batch.Humidity;
            result.CoffeeVariety = GetCoffeeVariety(detail);
            result.CoffeeType = GetCoffeeType(detail);
            result.Purchase = GetPurchaseBatch(detail);
            return result;
        }

        private CoffeeVarietyGetPurchase? GetCoffeeVariety(DetailPurchaseCoffeeProducer detail)
        {
            var variety = detail.Batch.CoffeeVariety;
            if (variety == null)
            {
                return null;
            }

            return new CoffeeVarietyGetPurchase {
                Id = variety.Id,
                Code = variety.Code,
                Name = variety.Name
            };
        }

        private CoffeeTypeGetPurchase GetCoffeeType(DetailPurchaseCoffeeProducer detail)
        {
            var type = detail.Batch.CoffeeType;
            return new CoffeeTypeGetPurchase {
                Id = type.Id,
                Code = type.Code,
                Name = type.Name
            };
        }

        private PurchaseBatchGetPurchase? GetPurchaseBatch(DetailPurchaseCoffeeProducer detail)
        {
            var purchase = detail.Batch.Purchase;
            if (purchase == null)
            {
                return null;
            }

            return new PurchaseBatchGetPurchase {
                Id = purchase.Id,
                Amount = purchase.Amount,
                MeasurementUnit = GetMeasurementUnit(detail),
                CoffeeMarketPrice = purchase.CoffeeMarketPrice,
                ExpectedBatchSellingPrice = purchase.ExpectedBatchSellingPrice
            };
        }

        private MeasurementUnitGetPurchase GetMeasurementUnit(DetailPurchaseCoffeeProducer detail)
        {
            var purchase = detail.Batch.Purchase!;

            return new MeasurementUnitGetPurchase {
                Id = purchase.MeasurementUnitCoffee.Id,
                Code = purchase.MeasurementUnitCoffee.Code,
                Name = purchase.MeasurementUnitCoffee.Name
            };
        }
    }
}
