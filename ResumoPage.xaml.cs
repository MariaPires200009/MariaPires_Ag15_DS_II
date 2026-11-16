namespace CadastroEventos;

public partial class ResumoPage : ContentPage, IQueryAttributable
{
    public ResumoPage()
    {
        InitializeComponent();
    }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        Evento evento = query["evento"] as Evento;
        if (evento != null)
        {
            BindingContext = evento;
        }
    }
}