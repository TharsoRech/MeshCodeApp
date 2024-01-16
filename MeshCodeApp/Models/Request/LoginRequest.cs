namespace MeshCodeApp.Models.Request
{
    public class LoginRequest
    {
        public LoginRequest(string email, string senha)
        {
            Cnpj = email;
            PasswordHash = senha;
        }

        public string Cnpj { get; private set; }
        public string PasswordHash { get; private set; }
    }
}
