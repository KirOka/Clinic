namespace Clinic.PL.Models
{
    /// <summary>
    /// Модель врача для редактирования
    /// </summary>
    public class DoctorEditModel
    {
        /// <summary>
        /// ФИО
        /// </summary>
        public string? FullName { get; set; }

        /// <summary>
        /// Кабинет
        /// </summary>
        public Guid Office { get; set; }

        /// <summary>
        /// Специализация
        /// </summary>
        public Guid Specialization { get; set; }

        /// <summary>
        /// Участок
        /// </summary>
        public Guid District { get; set; }
    }
}
