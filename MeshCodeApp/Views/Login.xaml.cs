namespace MeshCodeApp.Views;

public partial class Login : ContentPage
{
	public Login(LoginViewModel loginViewModel)
    {
        InitializeComponent();
        BindingContext = loginViewModel;
	}

}