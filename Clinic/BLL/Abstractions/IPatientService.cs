using Clinic.BLL.DTO;

namespace Clinic.BLL.Abstractions
{
    /// <summary>
    /// Cервис работы с пациентами (интерфейс)
    /// </summary>
    public interface IPatientService
    {
        /// <summary>
        /// Получить список
        /// </summary>
        /// <param name="page">номер страницы</param>
        /// <param name="pageSize">объем страницы</param>
        /// <returns></returns>
        Task<ICollection<PatientDTO>> GetPaged(int page, int pageSize, string sort);

        /// <summary>
        /// Получить
        /// </summary>
        /// <param name="id">идентификатор</param>
        /// <returns>ДТО пациента</returns>
        Task<PatientDTO> GetById(Guid id);

        /// <summary>
        /// Создать
        /// </summary>
        /// <param name="patientDTO">ДТО пациента</para
        Task<Guid> Create(PatientDTO patientDTO);

        /// <summary>
        /// Изменить
        /// </summary>
        /// <param name="id">идентификатор</param>
        /// <param name="patientDTO">ДТО пациента</param>
        Task Update(Guid id, PatientDTO patientDTO);

        /// <summary>
        /// Удалить
        /// </summary>
        /// <param name="id">идентификатор</param>
        Task Delete(Guid id);
    }
}
