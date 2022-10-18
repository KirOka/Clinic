using Clinic.DAL.Abstraction;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clinic.DAL.Entities
{
    /// <summary>
    /// Модель врача
    /// </summary>
    public class Doctor : IEntity<Guid>
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// ФИО
        /// </summary>
        public string? FullName { get; set; }

        /// <summary>
        /// Id кабинета
        /// </summary>
        [Column("Office")]
        public Guid OfficeId { get; set; }

        /// <summary>
        /// Кабинет
        /// </summary>
        public Office? Office { get; set; }

        /// <summary>
        /// Id специализации
        /// </summary>
        [Column("Specialization")]
        public Guid SpecializationId { get; set; }

        /// <summary>
        /// Специализация
        /// </summary>
        public Specialization? Specialization { get; set; }

        /// <summary>
        /// Id участока
        /// </summary>
        [Column("District")]
        public Guid DistrictId { get; set; }

        /// <summary>
        /// Участок
        /// </summary>
        public District? District { get; set; }
    }
}
