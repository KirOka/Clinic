using Clinic.DAL.Abstraction;
using Clinic.DAL.Entities;

namespace Clinic.DAL.Interfaces
{
    public interface IPatientsRepository : IRepository<Patient, Guid>
    {
        /// <summary>
        /// Получить постраничный список
        /// </summary>
        /// <param name="page">номер страницы</param>
        /// <param name="itemsPerPage">объем страницы</param>
        /// <returns>список ДТО пациентов</returns>
        Task<List<Patient>> GetPagedAsync(int page, int itemsPerPage, string sort);
    }
}
