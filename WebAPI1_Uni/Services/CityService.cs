using WebAPI1_Uni.Dtoes.DeleteDtoes;
using WebAPI1_Uni.Dtoes.GetDtoes;
using WebAPI1_Uni.Dtoes.PostDtoes;
using WebAPI1_Uni.Dtoes.PutDtoes;
using WebAPI1_Uni.Interfaces;

namespace WebAPI1_Uni.Services
{
    public class CityService : ICity
    {

        public Task<List<CityGetDto>> DeleteCity(DeleteCityDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<List<CityGetDto>> GetAllCity()
        {
            throw new NotImplementedException();
        }

        public Task<CityGetDto> GetByIdCity(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CityGetDto>> PostCity(PostCityDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<List<CityGetDto>> PutCity(PutCityDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
