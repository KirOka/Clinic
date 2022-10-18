using Clinic.DAL.Data;
using Clinic.DAL.Entities;
using Clinic.DAL.Helpers;
using Clinic.DAL.Implementation;
using Clinic.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Clinic.DAL.Repositories
{
    /// <summary>
    /// Репозиторий работы с пациентами
    /// </summary>
    public class PatientRepository : Repository<Patient, Guid>, IPatientsRepository
    {
        private ISortHelper<Patient> _sortHelper;
        public PatientRepository(ApplicationContext context, ISortHelper<Patient> sortHelper) : base(context)
        {
            _sortHelper = sortHelper;
        }

        /// <summary>
        /// Получить постраничный список
        /// </summary>
        /// <param name="page">номер страницы</param>
        /// <param name="itemsPerPage">объем страницы</param>
        /// <returns>список ДТО пациентов</returns>
        public async Task<List<Patient>> GetPagedAsync(int page, int itemsPerPage, string sort)
        {
            var query = GetAll();
            var sorted = _sortHelper.ApplySort(query, sort);
            return await sorted
                .Skip((page - 1) * itemsPerPage)
                .Take(itemsPerPage)
                .ToListAsync();
        }
    }
}
