namespace Clinic.PL.Models
{
    /// <summary>
    /// Модель врача
    /// </summary>
    public class DoctorModel
    {
        /// <summary>
        /// ФИО
        /// </summary>
        public string? FullName { get; set; }

        /// <summary>
        /// Кабинет
        /// </summary>
        public int Office { get; set; }

        /// <summary>
        /// Специализация
        /// </summary>
        public string? Specialization { get; set; }

        /// <summary>
        /// Участок
        /// </summary>
        public int District { get; set; }
    }
}
