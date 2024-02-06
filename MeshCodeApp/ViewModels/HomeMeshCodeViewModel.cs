using MeshCodeApp.Helpers;
using MeshCodeApp.Models.Response;

namespace MeshCodeApp.ViewModels
{
    public partial class HomeMeshCodeViewModel:BaseViewModel
    {
        #region Properties
        [ObservableProperty]
        UserDto user;
        #endregion

        public HomeMeshCodeViewModel()
        {
            User = SessionHelper.User;
        }

        [RelayCommand]
        public async Task Sair()
        {
            await RouteHelpers.LogoffAsync();
        }
    }
}
