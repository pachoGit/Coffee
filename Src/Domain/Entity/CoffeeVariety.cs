using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    /// <summary>
    /// Representa la variedad de cafe
    /// </summary>
	[Table("coffee_variety")]
    public class CoffeeVariety
    {
        /// <value>
        /// Identificador de la variedad de cafe
        /// </value>
 		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column("id", TypeName = "int")]
        public int Id { get; set; }

        /// <value>
        /// Codigo de la variedad de cafe
        /// Prefijo: CV
        /// </value>
		[Column("code", TypeName = "varchar(4)")]
        public String Code { get; set; } = String.Empty;

        /// <value>
        /// Nombre de la variedad de cafe
        /// </value>
		[Column("name", TypeName = "varchar(50)")]
        public String? Name { get; set; }
    }
}
