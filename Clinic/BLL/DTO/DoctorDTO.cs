using System.ComponentModel.DataAnnotations.Schema;

namespace Clinic.BLL.DTO
{
    /// <summary>
    /// ДТО врача
    /// </summary>
    public class DoctorDTO
    {
        /// <summary>
        /// ФИО
        /// </summary>
        public string? FullName { get; set; }

        /// <summary>
        /// Id кабинета
        /// </summary>
        public Guid OfficeId { get; set; }

        /// <summary>
        /// Кабинет
        /// </summary>
        public int Office { get; set; }

        /// <summary>
        /// Id специализации
        /// </summary>
        public Guid SpecializationId { get; set; }

        /// <summary>
        /// Специализация
        /// </summary>
        public string? Specialization { get; set; }

        /// <summary>
        /// Id участока
        /// </summary>
        public Guid DistrictId { get; set; }

        /// <summary>
        /// Участок
        /// </summary>
        public int District { get; set; }
    }
}
