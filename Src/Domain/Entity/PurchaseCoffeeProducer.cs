using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    /// <summary>
    /// Representa a una compra de cafe del productor
    /// </summary>
    [Table("purchase_coffee_producer")]
    public class PurchaseCoffeeProducer
    {
        /// <value>
        /// Identificador de la compra
        /// </value>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id", TypeName = "int")]
        public int Id { get; set; }

        /// <value>
        /// Fecha de compra del cafe
        /// </value>
        [Column("purchase_date", TypeName = "datetime")]
        public DateTime PurchaseDate { get; set; } = new();

        /// <value>
        /// El identificador del productor de cafe
        /// </value>
        [Column("coffee_producer_id", TypeName = "int")]
        public int CoffeeProducerId { get; set; }

        /// <value>
        /// Precio total de la compra
        /// </value>
        [Column("total_price", TypeName = "decimal(18,4)")]
        public decimal TotalPrice { get; set; } = 0;

        /// <value>
        /// Fecha de la creacion del registro de la compra de cafe
        /// </value>
        [Column("created_at", TypeName = "datetime")]
        public DateTime CreatedAt { get; set; } = new();

        /// <value>
        /// Fecha de última actualización de la compra de cafe
        /// </value>
        [Column("updated_at", TypeName = "datetime")]
        public DateTime UpdateAt { get; set; } = new();

        /// <value>
        /// Fecha de eliminación de la compra de cafe
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

        /*
         * Relaciones inversas
         */

        /// <value>
        /// Detalles de la compra de cafe
        /// </value>
        public ICollection<DetailPurchaseCoffeeProducer> DetailPurchases { get; set; } = new List<DetailPurchaseCoffeeProducer>();
    }
}
