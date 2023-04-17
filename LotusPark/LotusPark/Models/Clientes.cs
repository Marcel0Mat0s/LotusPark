namespace LotusPark.Models {
    public class Clientes {
        public int id { get; set; }
        public string nome { get; set; }
        public int NIF { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string cod_postal { get; set; }
        public DateOnly data_nascimento { get; set; }
    }
}
