using MeshCodeApp.Helpers;
using MeshCodeApp.Models.Response;
using MeshCodeApp.Repository.MeshRepository;

namespace MeshCodeApp.ViewModels.Pages
{
    public partial class ProfilePageViewModel:BaseViewModel
    {
        #region Variables
        IMeshRepository _meshRepository;
        #endregion

        [ObservableProperty]
        UserDto userInfo;
        public ProfilePageViewModel(IMeshRepository meshRepository)
        {
            _meshRepository = meshRepository;   
            UserInfo = SessionHelper.User;
        }
    }
}
