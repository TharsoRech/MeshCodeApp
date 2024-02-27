using MeshCodeApp.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeshCodeApp.Repository.MeshRepository
{
    public class MeshRepository: IMeshRepository
    {
        public async Task<decimal> GetBalanceAsync()
        {
			try
			{
				return 10;
			}
			catch (Exception)
			{
				return 0;
			}
        }

		public async Task<List<CupomDto>> GetLastCupoms()
		{
            List<CupomDto> list = new List<CupomDto>();
            try
			{
				for(int i = 0; i < 3; i++)
				{
					list.Add(new CupomDto
					{
						Name = $"Cupom de desconto promocional da loja {i}",
						EstablishmentId = i,
						Ativo = true,
						Value = 10 + i,
						DescountPercent = 10,
						Image = "store.svg"
					});
                }
				return list;

            }
			catch (Exception)
			{
				return list;

            }
		}
    }
}
