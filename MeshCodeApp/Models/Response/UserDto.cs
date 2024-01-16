namespace MeshCodeApp.Models.Response
{
    public class UserDto
    {
       public string token { get;set; }

        public string refreshToken { get; set; }

        public Guid establishmentId { get; set; }

        public string razaoSocial { get; set; }

        public string endereco { get; set; }

        public string numero { get; set; }

        public string complemento { get; set; }

        public string bairro { get; set; }
        public string cidade { get; set; }
        public string cep { get; set; }
        public string uf { get; set; }

        public bool isDeleted { get; set; }

        public string phoneNumber { get; set; }

        public string cnpj { get; set; }

        public DateTime createAt { get; set; }

    }
}
