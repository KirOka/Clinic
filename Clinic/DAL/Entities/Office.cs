using Clinic.DAL.Abstraction;

namespace Clinic.DAL.Entities
{
    /// <summary>
    /// Модель кабинета
    /// </summary>
    public class Office : IEntity<Guid>
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
        /// Врачи
        /// </summary>
        public List<Doctor> Doctors { get; set; } = new List<Doctor>();
    }
}
