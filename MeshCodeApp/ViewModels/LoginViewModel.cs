using CommunityToolkit.Maui.Alerts;
using MeshCodeApp.Contracts;
using MeshCodeApp.Helpers;
using MeshCodeApp.Models.Request;
using MeshCodeApp.Repository.Login;
using Microsoft.Extensions.DependencyInjection;
using System.Text;

namespace MeshCodeApp.ViewModels
{
    public partial class LoginViewModel:BaseViewModel
    {

        #region Properties
        [ObservableProperty]
        string cpfCpnj;

        [ObservableProperty]
        string senha;

        #endregion

        #region Variables
        ILoginRepositorio _loginRepositorio;
        #endregion

        public LoginViewModel()
        {
            _loginRepositorio = ServiceHelper.GetService<ILoginRepositorio>();
        }

        [RelayCommand]
        public async Task Login()
        {
            var loginRequest = new LoginRequest(CpfCpnj.RemoveSpecialCharacters(), SessionHelper.MD5Hash(Senha));

            var contract = new LoginContract(loginRequest);

            if (!contract.IsValid)
            {
                var messages = contract.Notifications.Select(x => x.Message);
                var sb = new StringBuilder();

                foreach (var message in messages)
                    sb.Append($"{message}\n");

                await Shell.Current.DisplayAlert("Atenção", sb.ToString(), "OK");
                return;
            }

            var result = await _loginRepositorio.LoginAsync(loginRequest);

            if (result is null || string.IsNullOrEmpty(result.token))
            {
                var toast = Toast.Make("Falha ao realizar login, tenta novamente!", CommunityToolkit.Maui.Core.ToastDuration.Long);
                await toast.Show();
                return;
            }

            SessionHelper.User = result;
            SessionHelper.SaveToken();

            Application.Current.MainPage = new HomeMeshCode(new HomeMeshCodeViewModel());   
        }
    }
}
