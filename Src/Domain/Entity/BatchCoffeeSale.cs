namespace Domain.Entity
{
    /// <summary>
    /// Representa a un lote de venta de cafe
    /// </summary>
    public class BatchCoffeeSeller
    {
        /// <value>
        /// Identificador del lote de venta de cafe
        /// </value>
        public int Id { get; set; }

        /// <value>
        /// Lotes de compra de cafe del lote de venta de cafe
        /// </value>
        public ICollection<PurchaseBatchCoffee> Purchases = new List<PurchaseBatchCoffee>();
    }
}
