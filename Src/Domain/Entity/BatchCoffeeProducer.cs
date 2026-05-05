using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    /// <summary>
    /// Representa a un lote de cafe del productor para comprar
    /// </summary>
	[Table("batch_coffee_producer")]
    public class BatchCoffeeProducer
    {
        /// <value>
        /// Identificador del lote de cafe
        /// </value>
 		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column("id", TypeName = "int")]
        public int Id { get; set; }

        /// <value>
        /// Puntaje SCA (Specialty Coffee Association) del lote de cafe
        /// </value>
		[Column("score_sca", TypeName = "decimal(18,4)")]
        public decimal ScoreSCA { get; set; } = 0;

        /// <value>
        /// Tamaño del grano de cafe
        /// </value>
		[Column("screen_size", TypeName = "decimal(18,4)")]
        public decimal ScreenSize { get; set; } = 0;

        /// <value>
        /// Variedad de cafe del lote de cafe
        /// </value>
		[Column("coffee_variety_id", TypeName = "int")]
        public int? CoffeeVarietyId { get; set; } = null;

        /// <value>
        /// Tipo de cafe del lote de cafe
        /// </value>
		[Column("coffee_type_id", TypeName = "int")]
        public int CoffeeTypeId { get; set; }

        /// <value>
        /// Humedad del lote de cafe
        /// </value>
		[Column("humidity", TypeName = "decimal(18,4)")]
        public decimal Humidity { get; set; } = 0;

        /// <value>
        /// El identificador del productor al que le pertenece el lote de cafe
        /// </value>
		[Column("coffee_producer_id", TypeName = "int")]
        public int CoffeeProducerId { get; set; }

        /// <value>
        /// Fecha de creación del productor
        /// </value>
		[Column("created_at", TypeName = "datetime")]
        public DateTime CreatedAt { get; set; } = new();

        /// <value>
        /// Fecha de última actualización del productor
        /// </value>
		[Column("updated_at", TypeName = "datetime")]
        public DateTime UpdateAt { get; set; } = new();

        /// <value>
        /// Fecha de eliminación del productor
        /// </value>
		[Column("deleted_at", TypeName = "datetime")]
        public DateTime? DeleteAt { get; set; } = null;

        /*
         * Relaciones directas
         */

        /// <value>
        /// El productor al que le pertenece el lote de cafe
        /// </value>
        [ForeignKey("CoffeeProducerId")]
        public CoffeeProducer Producer { get; set; } = null!;

        /// <value>
        /// El tipo de cafe del lote de cafe
        /// </value>
        [ForeignKey("CoffeeTypeId")]
        public CoffeeType CoffeeType { get; set; } = null!;

        /// <value>
        /// La variedad de cafe del lote de cafe
        /// </value>
        [ForeignKey("CoffeeVarietyId")]
        public CoffeeVariety? CoffeeVariety { get; set; } = null;

        /// <value>
        /// La compra del lote de cafe
        /// </value>
        // public PurchaseBatchCoffee? Purchase { get; set; } = null;

        /*
         * Relaciones inversas
         */
    }
}
