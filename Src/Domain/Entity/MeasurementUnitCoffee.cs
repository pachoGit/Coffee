using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    /// <summary>
    /// Representa la unidad de medida del cafe
    /// </summary>
    [Table("measurement_unit_coffee")]
    public class MeasurementUnitCoffee
    {
        /// <value>
        /// Identificador de la unidad de medidad de cafe
        /// </value>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id", TypeName = "int")]
        public int Id { get; set; }

        /// <value>
        /// Codigo de la unidad de medida de cafe
        /// Prefijo: MUC
        /// </value>
		[Column("code", TypeName = "varchar(5)")]
        public String Code { get; set; } = String.Empty;

        /// <value>
        /// Nombre de la unidad de medida del cafe
        /// </value>
		[Column("name", TypeName = "varchar(50)")]
        public String Name { get; set; } = String.Empty;
    }
}
