using Flurl;
using Flurl.Http;
using MeshCodeApp.Helpers;
using MeshCodeApp.Models.Request;
using MeshCodeApp.Models.Response;

namespace MeshCodeApp.Repository.Login
{
    public class LoginRepositorio : ILoginRepositorio
    {
        public async Task<LoginResponse> LoginAsync(LoginRequest loginRequest)
        {
            try
            {
                var response = await Urls.MeshCodeURL
                    .AppendPathSegment("/users/login")
                    .PutJsonAsync(loginRequest);

                if (response.ResponseMessage.IsSuccessStatusCode)
                {
                    var content = await response.ResponseMessage.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<LoginResponse>(content);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return new LoginResponse();
        }
    }
}
