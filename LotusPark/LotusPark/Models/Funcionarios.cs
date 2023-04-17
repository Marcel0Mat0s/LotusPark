namespace LotusPark.Models {
    public class Funcionarios {
        public int id { get; set; }
        public string nome { get; set; }
        public int NIF { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string cod_postal { get; set; }
        public string cargo { get; set; }
        public DateOnly data_nascimento { get; set; }
    }
}
