using MeshCodeApp.ViewModels.Pages;

namespace MeshCodeApp.Views.Pages;

public partial class ProfilePage : ContentPage
{
	public ProfilePage(ProfilePageViewModel profilePageViewModel)
	{
		InitializeComponent();
		BindingContext = profilePageViewModel;
	}
}