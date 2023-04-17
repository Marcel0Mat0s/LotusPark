using System.ComponentModel.DataAnnotations.Schema;

namespace LotusPark.Models {
    public class Reservas {

        public Reservas() { 
        
            ListaVagas = new HashSet<Vagas>(); 
            ListaFuncionario = new HashSet<Funcionarios>();
        
        }

        public int Id { get; set; }
        public DateOnly DataEntrada { get; set; }
        public DateOnly DataSaida { get; set; }
        public DateTime HoraEntrada { get; set; }
        public DateTime HoraSaida { get; set; }
        public string Estado { get; set; }

        //*********************************************

        /// <summary>
        /// FK o cliente que fez a reserva
        /// </summary>
        [ForeignKey(nameof(Cliente))]
        public int ClienteFK { get; set; }
        public Clientes Cliente { get; set; }

        /// <summary>
        /// Lista de vagas que foram reservadas
        /// </summary>
        public ICollection<Vagas> ListaVagas { get; set; }

        public ICollection<Funcionarios> ListaFuncionario { get; set; }
    }
}
