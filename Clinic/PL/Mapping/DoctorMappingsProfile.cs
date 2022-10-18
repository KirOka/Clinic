using AutoMapper;
using Clinic.BLL.DTO;
using Clinic.DAL.Entities;
using Clinic.PL.Models;

namespace Clinic.PL.Mapping
{
    /// <summary>
    /// Профиль автомаппера для сущности врача.
    /// </summary>
    public class DoctorMappingsProfile : Profile
    {
        public DoctorMappingsProfile()
        {
            CreateMap<DoctorDTO, DoctorModel>();

            CreateMap<DoctorModel, DoctorDTO>()
                .ForMember(d => d.OfficeId, map => map.Ignore())
                .ForMember(d => d.SpecializationId, map => map.Ignore())
                .ForMember(d => d.DistrictId, map => map.Ignore());
        }
    }
}
