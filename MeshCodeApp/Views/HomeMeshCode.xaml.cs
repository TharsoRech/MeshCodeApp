namespace MeshCodeApp.Views;

public partial class HomeMeshCode : ContentPage
{
	public HomeMeshCode(HomeMeshCodeViewModel homeMeshCodeViewModel)
	{
		BindingContext = homeMeshCodeViewModel;
		InitializeComponent();
	}
}