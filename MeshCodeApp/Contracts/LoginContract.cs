using MeshCodeApp.Models.Request;
using Flunt.Validations;

namespace MeshCodeApp.Contracts
{
    public class LoginContract : Contract<LoginRequest>
    {
        public LoginContract(LoginRequest request)
        {
            Requires()
                .IsNotNullOrEmpty(request.Cnpj, "Cpf/Cnpj", "Cpf/Cnpj não pode ser vazio")
                .IsNotNullOrEmpty(request.PasswordHash, "Senha", "Senha não pode ser vazia");
        }
    }
}
