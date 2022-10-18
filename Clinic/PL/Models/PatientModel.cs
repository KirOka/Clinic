namespace Clinic.PL.Models
{
    /// <summary>
    /// Модель пациента
    /// </summary>
    public class PatientModel
    {
        /// <summary>
        /// Фамилия
        /// </summary>
        public string? Surname { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        public string? Patronymic { get; set; }

        /// <summary>
        /// Адрес
        /// </summary>
        public string? Address { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        public string? Birthdate { get; set; }

        /// <summary>
        /// Пол
        /// </summary>
        public string? Gender { get; set; }

        /// <summary>
        /// Участок
        /// </summary>
        public int District { get; set; }
    }
}
