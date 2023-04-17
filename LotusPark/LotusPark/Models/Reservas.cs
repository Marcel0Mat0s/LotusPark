namespace LotusPark.Models {
    public class Reservas {
        public int id { get; set; }
        public DateOnly data_entrada { get; set; }
        public DateOnly data_saida { get; set; }
        public DateTime hora_entrada { get; set; }
        public DateTime hora_saida { get; set; }
        public string estado { get; set; }
    }
}
