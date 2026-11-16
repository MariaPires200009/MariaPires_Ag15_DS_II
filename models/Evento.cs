namespace CadastroEventos;

    public class Evento
    {
        public string Nome { get; set; } = string.Empty;
        public DateTime DataInicio { get; set; }
        public DateTime DataFim {get; set; }
        public string Local { get; set; } = string.Empty;
        public int NumeroParticipantes {get; set; }
        public decimal CustoParticipante {get; set; }
        public decimal CustoTotal => NumeroParticipantes * CustoParticipante;
        public int Duracao => (DataFim - DataInicio).Days; 
        public TimeSpan Intervalo => (DataFim - DataInicio);
        
        public Evento()
        {
            this.NumeroParticipantes =0;
        }
}
