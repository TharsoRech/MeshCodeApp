namespace MeshCodeApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(Login), typeof(Login));
        Routing.RegisterRoute(nameof(HomeMeshCode), typeof(HomeMeshCode));
    }
}
