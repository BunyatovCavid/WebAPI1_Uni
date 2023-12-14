using WebAPI1_Uni.Dtoes.DeleteDtoes;
using WebAPI1_Uni.Dtoes.GetDtoes;
using WebAPI1_Uni.Dtoes.PostDtoes;
using WebAPI1_Uni.Dtoes.PutDtoes;

namespace WebAPI1_Uni.Interfaces
{
    public interface ICity
    {
        public Task<CityGetDto> GetByIdCity(int id);//Select .... Where id=
        public Task<List<CityGetDto>> GetAllCity();//Select
        public Task<List<CityGetDto>> PostCity(PostCityDto dto);//Insert
        public Task<List<CityGetDto>> PutCity(PutCityDto dto);//Update
        public Task<List<CityGetDto>> DeleteCity(DeleteCityDto dto);//Delete
    }
}
