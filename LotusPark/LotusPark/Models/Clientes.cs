using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace LotusPark.Models {
    public class Clientes {

        public Clientes() { 
        
            ListaReservas = new HashSet<Reservas>();
        
        }


        public int Id { get; set; }

        /// <summary>
        /// Nome do cliente
        /// </summary>
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório.")]
        [StringLength(50, ErrorMessage = "O {0} não pode ter mais de {1} caracteres.")]
        public string Nome { get; set; }

        /// <summary>
        /// Número de identificação fiscal do cliente
        /// </summary>
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório.")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "O {0} deve ter exatamente {1} caracteres.")]
        [RegularExpression("[12567][0-9]{8}", ErrorMessage = "Deve escrever um número com 9 algarismos, começando por 1, 2, 5, 6 ou 7.")]
        public string NIF { get; set; }

        /// <summary>
        /// Telefone do cliente
        /// </summary>
        [DisplayName("Telemóvel")]
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "O {0} deve ter exatamente {1} caracteres")]
        [RegularExpression("[9][1236][0-9]{7}", ErrorMessage = "O {0} deve começar por 9 e ter 9 dígitos")]
        //  ((+|00)[0-9]{2,5})?[0-9]{5,9}
        public string Telefone { get; set; }

        /// <summary>
        /// Email do cliente
        /// </summary>
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório.")]
        [StringLength(50, ErrorMessage = "O {0} não pode ter mais de {1} caracteres.")]
        [RegularExpression("[a-z0-9.]+@[a-z0-9.]+", ErrorMessage = "Deve escrever um email válido.")]
        public string Email { get; set; }

        /// <summary>
        /// Código postal do cliente
        /// </summary>
        [Required(ErrorMessage ="O {0} é de preenchimento obrigatório")]
        [DisplayName("Código Postal")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "O {0} deve ter exatamente {1} caracteres.")]
        [RegularExpression("[0-9]{4}(-)[0-9]{3}", ErrorMessage = "Deve escrever um código postal válido.")]

        public string CodPostal { get; set; }

        /// <summary>
        /// Morada do cliente
        /// </summary>
        [Required(ErrorMessage = "A {0} é de preenchimento obrigatório")]
        [StringLength(100, ErrorMessage = "A {0} não pode ter mais de {1} caracteres.")]
        public string Morada { get; set; }

        /// <summary>
        /// Data de nascimento do cliente
        /// </summary>

        [DisplayName("Data de Nascimento")]
        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "A {0} é de preenchimento obrigatório.")]
        public DateTime DataNascimento { get; set; }

        //*********************************************

        /// <summary>
        /// Atributo para ligar aos dados de autenticação de um utilizador
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Lista de reservas que o cliente fez
        /// </summary>
        public ICollection<Reservas> ListaReservas { get; set; }
    }
}
