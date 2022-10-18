using AutoMapper;
using Clinic.BLL.DTO;
using Clinic.DAL.Entities;
using System.Net;

namespace Clinic.BLL.Mapping
{
    /// <summary>
    /// Профиль автомаппера для сущности врача.
    /// </summary>
    public class PatientMappingsProfile : Profile
    {
        public PatientMappingsProfile()
        {
            CreateMap<Patient, PatientDTO>()
                .IncludeMembers(u => u.District, u => u.District)
                .ForPath(d => d.District, map => map.MapFrom(u => u.District.Number));
            CreateMap<District, PatientDTO>(MemberList.None);

            CreateMap<PatientDTO, Patient>()
                .ForMember(d => d.Id, map => map.Ignore())
                //.ForMember(d => d.DistrictId, map => map.Ignore())
                .ForPath(d => d.District.Number, map => map.MapFrom(u => u.District));
        }
    }
}
