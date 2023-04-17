using System.ComponentModel.DataAnnotations.Schema;

namespace LotusPark.Models {
    public class Vagas {
        public int Id { get; set; }
        public string Numero { get; set; }
        public string Estado { get; set; }

        //*********************************************

        /// <summary>
        /// FK da reserva que reservou a vaga
        /// </summary>
        [ForeignKey(nameof(Reserva))]
        public int ReservaFK { get; set; }
        public Reservas Reserva { get; set; }
    }
}
