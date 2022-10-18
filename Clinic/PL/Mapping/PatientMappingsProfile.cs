using AutoMapper;
using Clinic.BLL.DTO;
using Clinic.DAL.Entities;
using Clinic.PL.Models;

namespace Clinic.PL.Mapping
{
    /// <summary>
    /// Профиль автомаппера для сущности врача.
    /// </summary>
    public class PatientMappingsProfile : Profile
    {
        public PatientMappingsProfile()
        {
            CreateMap<PatientDTO, PatientModel>();

            CreateMap<PatientModel, PatientDTO>()
                .ForMember(d => d.DistrictId, map => map.Ignore());
        }
    }
}
