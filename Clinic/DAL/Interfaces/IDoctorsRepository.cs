using Clinic.DAL.Abstraction;
using Clinic.DAL.Entities;

namespace Clinic.DAL.Interfaces
{
    public interface IDoctorsRepository : IRepository<Doctor, Guid>
    {
        /// <summary>
        /// Получить постраничный список
        /// </summary>
        /// <param name="page">номер страницы</param>
        /// <param name="itemsPerPage">объем страницы</param>
        /// <returns>список ДТО врачей</returns>
        Task<List<Doctor>> GetPagedAsync(int page, int itemsPerPage, string sort);
    }
}
