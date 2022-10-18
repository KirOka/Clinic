using AutoMapper;
using Clinic.BLL.DTO;
using Clinic.DAL.Entities;

namespace Clinic.BLL.Mapping
{
    /// <summary>
    /// Профиль автомаппера для сущности врача.
    /// </summary>
    public class DoctorMappingsProfile : Profile
    {
        public DoctorMappingsProfile()
        {
            CreateMap<Doctor, DoctorDTO>()
                .IncludeMembers(u => u.District, u => u.District)
                .IncludeMembers(u => u.Office, u => u.Office)
                .IncludeMembers(u => u.Specialization, u => u.Specialization)
                .ForPath(d => d.District, map => map.MapFrom(u => u.District.Number))
                .ForPath(d => d.Office, map => map.MapFrom(u => u.Office.Number))
                .ForPath(d => d.Specialization, map => map.MapFrom(u => u.Specialization.Name));
            CreateMap<District, DoctorDTO>(MemberList.None);
            CreateMap<Office, DoctorDTO>(MemberList.None);
            CreateMap<Specialization, DoctorDTO>(MemberList.None);

            CreateMap<DoctorDTO, Doctor>()
                .ForMember(d => d.Id, map => map.Ignore())
                //.ForMember(d => d.DistrictId, map => map.Ignore())
                .ForPath(d => d.District.Number, map => map.MapFrom(u => u.District))
                //.ForMember(d => d.OfficeId, map => map.Ignore())
                .ForPath(d => d.Office.Number, map => map.MapFrom(u => u.Office))
                //.ForMember(d => d.SpecializationId, map => map.Ignore())
                .ForPath(d => d.Specialization.Name, map => map.MapFrom(u => u.Specialization));
        }
    }
}
