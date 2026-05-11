using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    /// <summary>
    /// Representa a un productor de cafe
    /// </summary>
	[Table("coffee_producer")]
    public class CoffeeProducer
    {
        /// <value>
        /// Identificador del productor
        /// </value>
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column("id", TypeName = "int")]
        public int Id { get; set; }

        /// <value>
        /// Nombre del productor
        /// </value>
		[Column("firstname", TypeName = "varchar(140)")]
        public String FirstName  { get; set; } = String.Empty;

        /// <value>
        /// Apellido del productor
        /// </value>
		[Column("lastname", TypeName = "varchar(140)")]
        public String? LastName { get; set; } = null;

        /// <value>
        /// Número de documento de identificación del productor
        /// </value>
		[Column("document_number", TypeName = "varchar(20)")]
        public String? DocumentNumber { get; set; } = null;

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

        /*
         * Relaciones inversas
         */

        /// <value>
        /// Lista de lotes de cafe del productor
        /// </value>
        public ICollection<BatchCoffeeProducer> Batches { get; set; } = new List<BatchCoffeeProducer>();

        /// <value>
        /// Lista de compras de cafe al productor
        /// </value>
        public ICollection<PurchaseCoffeeProducer> Purchases { get; set; } = new List<PurchaseCoffeeProducer>();
    }
}
