using System.ComponentModel.DataAnnotations.Schema;

namespace LotusPark.Models {
    public class Vagas {

        public Vagas() {
        
            ListaReservas = new HashSet<Reservas>();
        
        }        

        public int Id { get; set; }
        public string Numero { get; set; }
        public string Estado { get; set; }

        //*********************************************

        /// <summary>
        /// Lista de Reservas que foram feitas para esta vaga
        /// </summary>
        public ICollection<Reservas> ListaReservas { get; set; }
    }
}
