using MeshCodeApp.ViewModels.Pages;

namespace MeshCodeApp.Views.Pages;

public partial class StorePage : ContentPage
{
	public StorePage(StorePageViewModel storePageViewModel)
	{
		InitializeComponent();
		BindingContext = storePageViewModel;
	}
}