using VirtualDj.Dtos.DTOPjesma;
using VirtualDj.Models;

namespace VirtualDj
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Pjesma,GetPjesmaDto>();
            CreateMap<AddPjesmaDto, Pjesma>();
            CreateMap<UpdatePjesmaDto, Pjesma>();
        }
    }
}
