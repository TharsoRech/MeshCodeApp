using MeshCodeApp.Helpers;
using MeshCodeApp.Models.Request;
using MeshCodeApp.Models.Response;
using RestSharp;
using System.Net;

namespace MeshCodeApp.Repository.Login
{
    public class LoginRepositorio : ILoginRepositorio
    {
        public async Task<UserDto> LoginAsync(LoginRequest loginRequest)
        {
            try
            {

                var client = new RestClient(Urls.MeshCodeURL);
                var request = new RestRequest("Establishment/authenticate", Method.Post);
                request.AddJsonBody(new { cnpj  = loginRequest.Cnpj, passwordHash  = loginRequest.PasswordHash});

                var response = await client.ExecuteAsync(request);

               if (response.IsSuccessStatusCode)
                {
                    var result = JsonSerializer.Deserialize<Result<UserDto>>(response.Content);
                    return result?.data;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }
    }
}
