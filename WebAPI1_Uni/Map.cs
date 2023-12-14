using AutoMapper;
using WebAPI1_Uni.Domain.Entities;
using WebAPI1_Uni.Dtoes.GetDtoes;

namespace WebAPI1_Uni
{
    public class Map:Profile
    {
        public Map()
        {
            //birinci hisseye datanin axtarilacagi tipi, ikinci hisseye ise datanin elave olunacagi tipi qeyd etmeliyik
            CreateMap<City, CityGetDto>();
        }
    }
}
