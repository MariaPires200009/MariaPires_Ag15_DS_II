using Microsoft.Extensions.DependencyInjection;

namespace MariaPires_Ag15_DS_II;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		return new Window(new AppShell());
	}
}