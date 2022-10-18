using Clinic.DAL.Abstraction;

namespace Clinic.DAL.Entities
{
    /// <summary>
    /// Модель участка
    /// </summary>
    public class District : IEntity<Guid>
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Номер
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Пациенты
        /// </summary>
        public List<Patient> Patients { get; set; } = new List<Patient>();

        /// <summary>
        /// Врачи
        /// </summary>
        public List<Doctor> Doctors { get; set; } = new List<Doctor>();
    }
}
