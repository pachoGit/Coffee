using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    /// <summary>
    /// Representa la compra de un lote de cafe
    /// </summary>
    [Table("purchase_batch_coffee")]
    public class PurchaseBatchCoffee
    {
        /// <value>
        /// Identificador de la compra
        /// </value>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id", TypeName = "int")]
        public int Id { get; set; }

        /// <value>
        /// Identificador de la unidad de medida de la compra
        /// </value>
        [Column("measurement_unit_coffee_id", TypeName = "int")]
        public int MeasurementUnitCoffeeId { get; set; }

        /// <value>
        /// Cantidad de la compra
        /// </value>
        [Column("amount", TypeName = "decimal(18,4)")]
        public decimal Amount { get; set; } = 0;

        /// <value>
        /// Precio venta de referencia del mercado del cafe
        /// </value>
        [Column("coffee_market_price", TypeName = "decimal(18,4)")]
        public decimal CoffeeMarketPrice { get; set; } = 0;

        /// <value>
        /// Precio de compra del lote de cafe
        /// </value>
        [Column("batch_purchase_price", TypeName = "decimal(18,4)")]
        public decimal BatchPurchasePrice { get; set; } = 0;

        /// <value>
        /// Precio de venta esperado de venta del lote de cafe.
        /// Puede ser que al momento de comprar el lote, ya se haya establecido el precio al cual
        /// se va a vender
        /// </value>
        [Column("expected_batch_selling_price", TypeName = "decimal(18,4)")]
        public decimal? ExpectedBatchSellingPrice { get; set; } = null;

        /// <value>
        /// Identificador del lote de cafe de la compra
        /// </value>
        [Column("batch_coffee_producer_id", TypeName = "int")]
        public int BatchCoffeeProducerId { get; set; }

        /// <value>
        /// Fecha de creación de la compra
        /// </value>
        [Column("created_at", TypeName = "datetime")]
        public DateTime CreatedAt { get; set; } = new();

        /// <value>
        /// Fecha de última actualización de la compra
        /// </value>
        [Column("updated_at", TypeName = "datetime")]
        public DateTime UpdateAt { get; set; } = new();

        /// <value>
        /// Fecha de eliminación de la compra
        /// </value>
        [Column("deleted_at", TypeName = "datetime")]
        public DateTime? DeleteAt { get; set; } = null;

        /*
         * Relaciones directas
         */

        /// <value>
        /// Lote de cafe del productor para la compra
        /// </value>
        [ForeignKey("BatchCoffeeProducerId")]
        public BatchCoffeeProducer Batch { get; set; } = null!;

        /// <value>
        /// Unidad de medida del cafe
        /// </value>
        [ForeignKey("MeasurementUnitCoffeeId")]
        public MeasurementUnitCoffee MeasurementUnitCoffee { get; set; } = null!;

        /*
         * Relaciones inversas
         */
    }
}
