namespace Domain.Entity
{
    /// <summary>
    /// Representa a un productor de cafe
    /// </summary>
    public class CoffeeProducer
    {
        /// <value>
        /// Identificador del productor
        /// </value>
        public int Id { get; set; }

        /// <value>
        /// Nombre del productor
        /// </value>
        public String FirstName  { get; set; } = String.Empty;

        /// <value>
        /// Apellido del productor
        /// </value>
        public String? LastName { get; set; }

        /// <value>
        /// Número de documento de identificación del productor
        /// </value>
        public String? DocumentNumber { get; set; }

        /// <value>
        /// Fecha de creación del productor
        /// </value>
        public DateTime CreatedAt { get; set; } = new();

        /// <value>
        /// Fecha de última actualización del productor
        /// </value>
        public DateTime UpdateAt { get; set; } = new();

        /// <value>
        /// Fecha de eliminación del productor
        /// </value>
        public DateTime? DeleteAt { get; set; }

        /*
         * Relaciones directas
         */

        /*
         * Relaciones inversas
         */

    }
}
