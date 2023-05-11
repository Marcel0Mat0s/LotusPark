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
        [StringLength(50)]
        public string Nome { get; set; }

        public int NIF { get; set; }

        [DisplayName("Telemóvel")]
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "O {0} deve ter exatamente {1} caracteres")]
        [RegularExpression("[9][1236][0-9]{7}", ErrorMessage = "O {0} deve começar por 9 e ter 9 dígitos")]
        //  ((+|00)[0-9]{2,5})?[0-9]{5,9}
        public string Telefone { get; set; }

        [EmailAddress(ErrorMessage = "O {0} não está corretamente escrito")]
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório")]
        [StringLength(40)]
        public string Email { get; set; }

        [DisplayName("Código Postal")]
        [RegularExpression("[0-9]{4}(-)[0-9]{3}", ErrorMessage = "O {0} deve ter o formato XXXX-XXX")]
        [StringLength(25)]
        public string CodPostal { get; set; }

        [StringLength(100)]
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
