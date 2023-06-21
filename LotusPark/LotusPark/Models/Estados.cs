using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LotusPark.Models {
    public class Estados {

        public Estados() {
        
            ListaVagas = new HashSet<Vagas>();
        
        }
        public int Id { get; set; }

        /// <summary>
        /// Nome do estado
        /// </summary>
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório")]
        [DisplayName("Estado")]
        [StringLength(50)]
        public string Nome { get; set; }

        //*********************************************

        /// <summary>
        /// Lista de vagas a que o estado foi designado
        /// </summary>
        public ICollection<Vagas> ListaVagas { get; set; }
    }
}
