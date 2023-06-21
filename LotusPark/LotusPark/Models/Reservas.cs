using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LotusPark.Models {
    public class Reservas {

        public Reservas() { 
        
            ListaVagas = new HashSet<Vagas>(); 
            ListaFuncionario = new HashSet<Funcionarios>();
        
        }

        /// <summary>
        /// Id da reserva
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Data de início da reserva
        /// </summary>
        [Required(ErrorMessage = "A {0} é de preenchimento obrigatório")]
        [DisplayName("Data de Entrada")]
        public DateTime DataEntrada { get; set; }

        /// <summary>
        /// Data de fim da reserva
        /// </summary>
        [Required(ErrorMessage = "A {0} é de preenchimento obrigatório")]
        [DisplayName("Data de Saída")]
        public DateTime DataSaida { get; set; }

        /// <summary>
        /// Estado da reserva
        /// </summary>
        [DisplayName("Estado da Reserva")]
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
