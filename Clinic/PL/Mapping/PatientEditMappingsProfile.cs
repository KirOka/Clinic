using AutoMapper;
using Clinic.BLL.DTO;
using Clinic.PL.Models;

namespace Clinic.PL.Mapping
{
    /// <summary>
    /// Профиль автомаппера для сущности врача для редактирования
    /// </summary>
    public class PatientEditMappingsProfile : Profile
    {
        public PatientEditMappingsProfile()
        {
            CreateMap<PatientDTO, PatientEditModel>()
                .ForPath(d => d.District, map => map.MapFrom(u => u.DistrictId));

            CreateMap<PatientEditModel, PatientDTO>()
                .ForMember(d => d.District, map => map.Ignore())
                .ForPath(d => d.DistrictId, map => map.MapFrom(u => u.District));
        }
    }
}
