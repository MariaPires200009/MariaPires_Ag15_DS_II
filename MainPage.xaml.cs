namespace CadastroEventos;

public partial class MainPage : ContentPage
{
    private Evento evento = new Evento();
    public MainPage()
    {
        InitializeComponent();
        BindingContext = evento;
    }

    private async void OnContinueClicked(object sender, EventArgs e)
    {

	    bool participantesValidos = int.TryParse(entryNumeroParticipantes.Text, out int numeroParticipantes);

	    bool custoValido = decimal.TryParse(entryCustoParticipante.Text, out decimal custoParticipante);

		if (!string.IsNullOrWhiteSpace(evento.Nome) && !string.IsNullOrWhiteSpace(evento.Local) && participantesValidos && custoValido && numeroParticipantes >0 && custoParticipante >= 0 && evento.DataFim >= evento.DataInicio)
		{
		   evento.NumeroParticipantes = numeroParticipantes;
		   evento.CustoParticipante = custoParticipante;

		   await Shell.Current.GoToAsync($"ResumoPage", new Dictionary<string, object>
			{
				["evento"] = evento
			});
		}

		else
		{
            
		    await DisplayAlertAsync("Erro", "Por favor, insira valores válidos para o número de participantes e o custo por participante.", "OK");
		}
    }


    
} 
 