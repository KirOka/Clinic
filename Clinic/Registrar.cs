using Clinic.BLL.Abstractions;
using Clinic.BLL.Service;
using Clinic.DAL.Entities;
using Clinic.DAL.Helpers;
using Clinic.DAL.Interfaces;
using Clinic.DAL.Repositories;
using Microsoft.AspNetCore.Cors.Infrastructure;
using System.Security.Principal;

namespace Clinic
{
    public static class Registrar
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services
                .InstallServices()
                .InstallRepositories()
                .InstallHelpers();
        }

        private static IServiceCollection InstallServices(this IServiceCollection serviceCollection)
        {
            serviceCollection
                .AddTransient<IDoctorService, DoctorService>()
                .AddTransient<IPatientService, PatientService>();
            return serviceCollection;
        }

        private static IServiceCollection InstallRepositories(this IServiceCollection serviceCollection)
        {
            serviceCollection
                .AddTransient<IDoctorsRepository, DoctorRepository>()
                .AddTransient<IPatientsRepository, PatientRepository>();
            return serviceCollection;
        }

        private static IServiceCollection InstallHelpers(this IServiceCollection serviceCollection)
        {
            serviceCollection
                .AddTransient<ISortHelper<Patient>, SortHelper<Patient>>()
                .AddTransient<ISortHelper<Doctor>, SortHelper<Doctor>>();
            return serviceCollection;
        }
    }
}
