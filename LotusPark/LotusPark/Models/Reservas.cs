using System.ComponentModel.DataAnnotations.Schema;

namespace LotusPark.Models {
    public class Reservas {

        public Reservas() { 
        
            ListaVagas = new HashSet<Vagas>(); 
            ListaFuncionario = new HashSet<Funcionarios>();
        
        }

        public int Id { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public string Estado { get; set; }

        //*********************************************

        /// <summary>
        /// FK do cliente que fez a reserva
        /// </summary>
        [ForeignKey(nameof(Cliente))]
        public int ClienteFK { get; set; }
        public Clientes? Cliente { get; set; }

        /// <summary>
        /// Lista de vagas que foram reservadas
        /// </summary>
        public ICollection<Vagas> ListaVagas { get; set; }

        /// <summary>
        /// Lista de funcionarios que foram designados para a reserva
        /// </summary>
        public ICollection<Funcionarios> ListaFuncionario { get; set; }
    }
}
