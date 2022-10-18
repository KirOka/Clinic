using Clinic.DAL.Abstraction;

namespace Clinic.DAL.Entities
{
    /// <summary>
    /// Модель специализации
    /// </summary>
    public class Specialization : IEntity<Guid>
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Врачи
        /// </summary>
        public List<Doctor> Doctors { get; set; } = new List<Doctor>();
    }
}
