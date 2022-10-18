using AutoMapper;

namespace Clinic
{
    public class MapperConfig
    {
        public static MapperConfiguration GetMapperConfiguration()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<BLL.Mapping.DoctorMappingsProfile>();
                cfg.AddProfile<BLL.Mapping.PatientMappingsProfile>();

                cfg.AddProfile<PL.Mapping.DoctorMappingsProfile>();
                cfg.AddProfile<PL.Mapping.PatientMappingsProfile>();

                cfg.AddProfile<PL.Mapping.DoctorEditMappingsProfile>();
                cfg.AddProfile<PL.Mapping.PatientEditMappingsProfile>();
            });
            try
            {
                configuration.AssertConfigurationIsValid();
            }
            catch (Exception ex)
            { }
            return configuration;
        }
    }
}
