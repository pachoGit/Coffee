using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    /// <summary>
    /// Representa al detalle de una compra de cafe del productor
    /// </summary>
	[Table("detail_purchase_coffee_producer")]
    public class DetailPurchaseCoffeeProducer
    {
        /// <value>
        /// Identificador del detalle de compra
        /// </value>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id", TypeName = "int")]
        public int Id { get; set; }

        /// <value>
        /// El identificador de la compra de cafe
        /// </value>
		[Column("purchase_coffee_producer_id", TypeName = "int")]
        public int PurchaseCoffeeProducerId { get; set; }

        /// <value>
        /// El identificador del productor que se compro el cafe
        /// </value>
		[Column("coffee_producer_id", TypeName = "int")]
        public int CoffeeProducerId { get; set; }

        /// <value>
        /// El identificador del lote de cafe
        /// </value>
		[Column("batch_coffee_producer_id", TypeName = "int")]
        public int BatchCoffeeProducerId { get; set; }

        /// <value>
        /// Fecha de la creacion del registro del detalle compra de cafe
        /// </value>
		[Column("created_at", TypeName = "datetime")]
        public DateTime CreatedAt { get; set; } = new();

        /// <value>
        /// Fecha de última actualización del detalle de compra de cafe
        /// </value>
		[Column("updated_at", TypeName = "datetime")]
        public DateTime UpdateAt { get; set; } = new();

        /// <value>
        /// Fecha de eliminación del detalle de compra de cafe
        /// </value>
		[Column("deleted_at", TypeName = "datetime")]
        public DateTime? DeleteAt { get; set; } = null;

        /*
         * Relaciones directas
         */

        /// <value>
        /// El productor de cafe
        /// </value>
        [ForeignKey("CoffeeProducerId")]
        public CoffeeProducer Producer { get; set; } = null!;

        /// <value>
        /// El lote de cafe del productor de cafe
        /// </value>
        [ForeignKey("BatchCoffeeProducerId")]
        public BatchCoffeeProducer Batch { get; set; } = null!;

        /// <value>
        /// El registro de compra de cafe
        /// </value>
        [ForeignKey("PurchaseCoffeeProducerId")]
        public PurchaseCoffeeProducer Purchase { get; set; } = null!;

        /*
         * Relaciones inversas
         */
    }
}
