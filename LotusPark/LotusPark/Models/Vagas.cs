using LotusPark.Data;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LotusPark.Models {
    public class Vagas {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Número da vaga
        /// </summary>
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório")]
        [DisplayName("Número da Vaga")]
        [RegularExpression("[0-9]{1,3}", ErrorMessage = "O {0} deve ter entre 1 a 3 dígitos")]
        [CustomValidation(typeof(Vagas), "ValidarNumeroVaga")]
        public string Numero { get; set; }


        //*********************************************

        /// <summary>
        /// FK do estado da vaga
        /// </summary>
        [ForeignKey(nameof(Estado))]
        public int EstadoFK { get; set; }
        public Estados? Estado { get; set; }

        /// <summary>
        /// FK da reserva que a vaga pertence (opcional)
        /// </summary>
        [ForeignKey(nameof(Reserva))]
        public int? ReservaFK { get; set; }
        public Reservas? Reserva { get; set; }

        //*********************************************

        /// <summary>
        /// Método que valida se o número da vaga é único
        /// </summary>
        /// <param name="numero"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public static ValidationResult ValidarNumeroVaga(string numero, ValidationContext context) {
            ApplicationDbContext dbContext = (ApplicationDbContext)context.GetService(typeof(ApplicationDbContext));

            // Verifica se já existe uma vaga com o número fornecido
            bool numeroExists = dbContext.Vagas.Any(v => v.Numero == numero);

            if (numeroExists) {
                return new ValidationResult("Essa vaga já existe.");
            }
            
            return ValidationResult.Success;
        }
    }
}
