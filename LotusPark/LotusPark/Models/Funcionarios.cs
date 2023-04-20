using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace LotusPark.Models {
    public class Funcionarios {

        public Funcionarios() {
        
            ListaReservas = new HashSet<Reservas>();
        
        }

        public int Id { get; set; }
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório")]

        [DisplayName("Nome Funcionário")]
        public string Nome { get; set; }

        public int NIF { get; set; }

        [DisplayName("Telemóvel")]
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório")]
        public string Telefone { get; set; }

        [EmailAddress(ErrorMessage = "O {0} não está corretamente escrito")]
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório")]
        public string Email { get; set; }

        [DisplayName("Código Postal")]
        public string CodPostal { get; set; }

        public string Morada { get; set; }

        public string Cargo { get; set; }

        [DisplayName("Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        //*********************************************

        /// <summary>
        /// Lista de reservas a que o funcionario foi designado
        /// </summary>
        public ICollection<Reservas> ListaReservas { get; set; }
    }
}
