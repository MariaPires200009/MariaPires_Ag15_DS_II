namespace MariaPires_Ag15_DS_II;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute("ResumoPage", typeof(CadastroEventos.ResumoPage));
	}
}
