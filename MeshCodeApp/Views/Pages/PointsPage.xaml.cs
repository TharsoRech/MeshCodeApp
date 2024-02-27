using MeshCodeApp.ViewModels.Pages;

namespace MeshCodeApp.Views.Pages;

public partial class PointsPage : ContentPage
{
	public PointsPage(PointsPageViewModel pointsPageViewModel)
	{
		InitializeComponent();
		BindingContext = pointsPageViewModel;
	}
}