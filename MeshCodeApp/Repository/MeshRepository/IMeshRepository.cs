using MeshCodeApp.Models.Response;

namespace MeshCodeApp.Repository.MeshRepository
{
    public interface IMeshRepository
    {
        Task<decimal> GetBalanceAsync();

        Task<List<CupomDto>> GetLastCupoms();
    }
}
