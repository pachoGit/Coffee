namespace Domain.Entity
{
    /// <summary>
    /// Representa la compra de un lote de cafe
    /// </summary>
    public class PurchaseBatchCoffee
    {
        /// <value>
        /// Identificador de la compra
        /// </value>
        public int Id { get; set; }

        /// <value>
        /// Identificador de la unidad de medida de la compra
        /// </value>
        public int MeasurementUnitId { get; set; }

        /// <value>
        /// Cantidad de la compra
        /// </value>
        public decimal Amount { get; set; }

        /// <value>
        /// Precio venta de referencia del mercado del cafe
        /// </value>
        public decimal CoffeeMarketPrice { get; set; }

        /// <value>
        /// Precio de compra del lote de cafe
        /// </value>
        public decimal BatchPurchasePrice { get; set; }

        /// <value>
        /// Precio de venta esperado del lote de cafe.
        /// Puede ser que al momento de comprar el lote, ya se haya establecido el precio al cual
        /// se va a vender
        /// </value>
        public decimal? ExpectedBatchSellingPrice { get; set; }

        /// <value>
        /// Identificador del lote de cafe de la compra
        /// </value>
        public int BatchCoffeeProducerId { get; set; }

        /// <value>
        /// Fecha de creación de la compra
        /// </value>
        public DateTime CreatedAt { get; set; } = new();

        /// <value>
        /// Fecha de última actualización de la compra
        /// </value>
        public DateTime UpdateAt { get; set; } = new();

        /// <value>
        /// Fecha de eliminación de la compra
        /// </value>
        public DateTime? DeleteAt { get; set; }

        /*
         * Relaciones directas
         */


        /*
         * Relaciones inversas
         */

        /// <value>
        /// Lote de cafe del productor para la compra
        /// </value>
        public BatchCoffeeProducer Batch { get; set; } = new();
    }
}
