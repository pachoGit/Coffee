namespace Domain.Entity
{
    /// <summary>
    /// Representa a un lote de cafe del productor para comprar
    /// </summary>
    public class BatchCoffeeProducer
    {
        /// <value>
        /// Identificador del lote de cafe
        /// </value>
        public int Id { get; set; }

        /// <value>
        /// Puntaje SCA (Specialty Coffee Association) del lote de cafe
        /// </value>
        public decimal ScoreSCA { get; set; }

        /// <value>
        /// Tamaño del grano de cafe
        /// </value>
        public decimal ScreenSize { get; set; }

        /// <value>
        /// Variedad de cafe del lote de cafe
        /// </value>
        public String? CoffeeVariety { get; set; }

        /// <value>
        /// Humedad del lote de cafe
        /// </value>
        public decimal Humidity { get; set; }

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

        /// <value>
        /// La compra del lote de cafe
        /// </value>
        public PurchaseBatchCoffee? Purchase { get; set; }

        /*
         * Relaciones inversas
         */
    }
}
