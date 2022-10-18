using AutoMapper;
using Clinic.BLL.Abstractions;
using Clinic.BLL.DTO;
using Clinic.DAL.Entities;
using Clinic.DAL.Interfaces;

namespace Clinic.BLL.Service
{
    /// <summary>
    /// Cервис работы с пациентами
    /// </summary>
    public class PatientService : IPatientService
    {
        private readonly IMapper _mapper;
        private readonly IPatientsRepository _patientRepository;

        public PatientService(
            IMapper mapper,
            IPatientsRepository patientRepository)
        {
            _mapper = mapper;
            _patientRepository = patientRepository;
        }

        /// <summary>
        /// Получить список
        /// </summary>
        /// <param name="page">номер страницы</param>
        /// <param name="pageSize">объем страницы</param>
        /// <returns></returns>
        public async Task<ICollection<PatientDTO>> GetPaged(int page, int pageSize, string sort)
        {
            ICollection<Patient> entities = await _patientRepository.GetPagedAsync(page, pageSize, sort);
            return _mapper.Map<ICollection<Patient>, ICollection<PatientDTO>>(entities);
        }

        /// <summary>
        /// Получить
        /// </summary>
        /// <param name="id">идентификатор</param>
        /// <returns>ДТО пациента</returns>
        public async Task<PatientDTO> GetById(Guid id)
        {
            var patient = await _patientRepository.GetAsync(id);
            return _mapper.Map<PatientDTO>(patient);
        }

        /// <summary>
        /// Создать
        /// </summary>
        /// <param name="patientDto">ДТО пациента</param>
        /// <returns>идентификатор</returns>
        public async Task<Guid> Create(PatientDTO patientDto)
        {
            var entity = _mapper.Map<PatientDTO, Patient>(patientDto);
            var res = await _patientRepository.AddAsync(entity);
            await _patientRepository.SaveChangesAsync();
            return res.Id;
        }

        /// <summary>
        /// Изменить
        /// </summary>
        /// <param name="id">идентификатор</param>
        /// <param name="patientDto">ДТО пациента</param>
        public async Task Update(Guid id, PatientDTO patientDto)
        {
            var entity = _mapper.Map<PatientDTO, Patient>(patientDto);
            entity.Id = id;
            _patientRepository.Update(entity);
            await _patientRepository.SaveChangesAsync();
        }

        /// <summary>
        /// Удалить
        /// </summary>
        /// <param name="id">идентификатор</param>
        public async Task Delete(Guid id)
        {
            _patientRepository.Delete(id);
            await _patientRepository.SaveChangesAsync();
        }
    }
}
