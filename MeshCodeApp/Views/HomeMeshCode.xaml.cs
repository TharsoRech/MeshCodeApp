using MeshCodeApp.Views.Pages;

namespace MeshCodeApp.Views;

public partial class HomeMeshCode : Shell
{
	public HomeMeshCode(HomeMeshCodeViewModel homeMeshCodeViewModel)
	{
        InitializeComponent();
        BindingContext = homeMeshCodeViewModel;
    }
}