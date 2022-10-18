using Clinic.DAL.Abstraction;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clinic.DAL.Entities
{
    /// <summary>
    /// Модель пациента
    /// </summary>
    public class Patient : IEntity<Guid>
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

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
        /// Id участка
        /// </summary>
        [Column("District")]
        public Guid DistrictId { get; set; }

        /// <summary>
        /// Участок
        /// </summary>
        public District? District { get; set; }
    }
}
