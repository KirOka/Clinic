using AutoMapper;
using Clinic.BLL.DTO;
using Clinic.PL.Models;

namespace Clinic.PL.Mapping
{
    /// <summary>
    /// Профиль автомаппера для сущности врача для редактирования.
    /// </summary>
    public class DoctorEditMappingsProfile : Profile
    {
        public DoctorEditMappingsProfile()
        {
            CreateMap<DoctorDTO, DoctorEditModel>()
                .ForPath(d => d.District, map => map.MapFrom(u => u.DistrictId))
                .ForPath(d => d.Office, map => map.MapFrom(u => u.OfficeId))
                .ForPath(d => d.Specialization, map => map.MapFrom(u => u.SpecializationId));

            CreateMap<DoctorEditModel, DoctorDTO>()
                .ForMember(d => d.Office, map => map.Ignore())
                .ForPath(d => d.OfficeId, map => map.MapFrom(u => u.Office))
                .ForMember(d => d.Specialization, map => map.Ignore())
                .ForPath(d => d.SpecializationId, map => map.MapFrom(u => u.Specialization))
                .ForMember(d => d.District, map => map.Ignore())
                .ForPath(d => d.DistrictId, map => map.MapFrom(u => u.District));
        }
    }
}
