using Clinic.BLL.DTO;

namespace Clinic.BLL.Abstractions
{
    /// <summary>
    /// Cервис работы с врачами (интерфейс)
    /// </summary>
    public interface IDoctorService
    {
        /// <summary>
        /// Получить список
        /// </summary>
        /// <param name="page">номер страницы</param>
        /// <param name="pageSize">объем страницы</param>
        /// <returns></returns>
        Task<ICollection<DoctorDTO>> GetPaged(int page, int pageSize, string sort);

        /// <summary>
        /// Получить
        /// </summary>
        /// <param name="id">идентификатор</param>
        /// <returns>ДТО врача</returns>
        Task<DoctorDTO> GetById(Guid id);

        /// <summary>
        /// Создать
        /// </summary>
        /// <param name="doctorDTO">ДТО пациента</para
        Task<Guid> Create(DoctorDTO doctorDTO);

        /// <summary>
        /// Изменить
        /// </summary>
        /// <param name="id">идентификатор</param>
        /// <param name="doctorDTO">ДТО врача</param>
        Task Update(Guid id, DoctorDTO doctorDTO);

        /// <summary>
        /// Удалить
        /// </summary>
        /// <param name="id">идентификатор</param>
        Task Delete(Guid id);
    }
}
