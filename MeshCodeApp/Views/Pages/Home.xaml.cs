using MeshCodeApp.ViewModels.Pages;

namespace MeshCodeApp.Views.Pages;

public partial class Home : ContentPage
{
	public Home(HomeViewModel homeViewModel)
	{
		InitializeComponent();
		BindingContext = homeViewModel;
	}
}