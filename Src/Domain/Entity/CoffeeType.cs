using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    /// <summary>
    /// Representa al tipo de cafe
    /// </summary>
	[Table("coffee_type")]
    public class CoffeeType
    {
        /// <value>
        /// Identificador del tipo de cafe
        /// </value>
 		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column("id", TypeName = "int")]
        public int Id { get; set; }

        /// <value>
        /// Codigo del tipo de cafe
        /// Prefijo: CT
        /// </value>
		[Column("code", TypeName = "varchar(4)")]
        public String Code { get; set; } = String.Empty;

        /// <value>
        /// Nombre del tipo de cafe
        /// </value>
		[Column("name", TypeName = "varchar(50)")]
        public String? Name { get; set; }
    }
}
