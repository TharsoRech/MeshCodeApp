using MeshCodeApp.Models.Response;
using MeshCodeApp.Repository.MeshRepository;

namespace MeshCodeApp.ViewModels.Pages
{
    public partial class HomeViewModel:BaseViewModel
    {
        [ObservableProperty]
        decimal saldo;

        [ObservableProperty]
        ObservableCollection<CupomDto> lastCupoms;

        #region Variables
        IMeshRepository _meshRepository;
        #endregion
        public HomeViewModel(IMeshRepository meshRepository)
        {
            _meshRepository = meshRepository;
            _= GetBalanceAsync();
            _ = GetLastCupomsAsync();
        }

        public async Task GetBalanceAsync()
        {
            Saldo = await _meshRepository.GetBalanceAsync();
        }

        public async Task GetLastCupomsAsync()
        {
            LastCupoms = new ObservableCollection<CupomDto>(await _meshRepository.GetLastCupoms());
        }

    }
}
