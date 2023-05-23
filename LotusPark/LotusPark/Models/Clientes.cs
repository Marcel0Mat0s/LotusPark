namespace LotusPark.Models {
    public class Clientes {

        public Clientes() { 
        
            ListaReservas = new HashSet<Reservas>();
        
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string NIF { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string CodPostal { get; set; }
        public string Morada { get; set; }
        public DateTime DataNascimento { get; set; }

        //*********************************************

        /// <summary>
        /// Lista de reservas que o cliente fez
        /// </summary>
        public ICollection<Reservas> ListaReservas { get; set; }
    }
}
