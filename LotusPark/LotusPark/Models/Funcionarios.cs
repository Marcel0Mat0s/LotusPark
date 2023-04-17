namespace LotusPark.Models {
    public class Funcionarios {

        public Funcionarios() {
        
            ListaReservas = new HashSet<Reservas>();
        
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int NIF { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string CodPostal { get; set; }
        public string Cargo { get; set; }
        public DateOnly DataNascimento { get; set; }

        //*********************************************

        public ICollection<Reservas> ListaReservas { get; set; }
    }
}
