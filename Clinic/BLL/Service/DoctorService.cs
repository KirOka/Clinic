using AutoMapper;
using Clinic.BLL.Abstractions;
using Clinic.BLL.DTO;
using Clinic.DAL.Abstraction;
using Clinic.DAL.Entities;
using Clinic.DAL.Interfaces;

namespace Clinic.BLL.Service
{
    /// <summary>
    /// Cервис работы с врачами
    /// </summary>
    public class DoctorService : IDoctorService
    {
        private readonly IMapper _mapper;
        private readonly IDoctorsRepository _doctorRepository;

        public DoctorService(
            IMapper mapper,
            IDoctorsRepository doctorRepository)
        {
            _mapper = mapper;
            _doctorRepository = doctorRepository;
        }

        /// <summary>
        /// Получить список
        /// </summary>
        /// <param name="page">номер страницы</param>
        /// <param name="pageSize">объем страницы</param>
        /// <returns></returns>
        public async Task<ICollection<DoctorDTO>> GetPaged(int page, int pageSize,string sort)
        {
            ICollection<Doctor> entities = await _doctorRepository.GetPagedAsync(page, pageSize, sort);
            return _mapper.Map<ICollection<Doctor>, ICollection<DoctorDTO>>(entities);
        }

        /// <summary>
        /// Получить
        /// </summary>
        /// <param name="id">идентификатор</param>
        /// <returns>ДТО врача</returns>
        public async Task<DoctorDTO> GetById(Guid id)
        {
            var doctor = await _doctorRepository.GetAsync(id);
            return _mapper.Map<DoctorDTO>(doctor);
        }

        /// <summary>
        /// Создать
        /// </summary>
        /// <param name="doctorDto">ДТО врача</param>
        /// <returns>идентификатор</returns>
        public async Task<Guid> Create(DoctorDTO doctorDto)
        {
            var entity = _mapper.Map<DoctorDTO, Doctor>(doctorDto);
            var res = await _doctorRepository.AddAsync(entity);
            await _doctorRepository.SaveChangesAsync();
            return res.Id;
        }

        /// <summary>
        /// Изменить
        /// </summary>
        /// <param name="id">идентификатор</param>
        /// <param name="doctorDto">ДТО врача</param>
        public async Task Update(Guid id, DoctorDTO doctorDto)
        {
            var entity = _mapper.Map<DoctorDTO, Doctor>(doctorDto);
            entity.Id = id;
            _doctorRepository.Update(entity);
            await _doctorRepository.SaveChangesAsync();
        }

        /// <summary>
        /// Удалить
        /// </summary>
        /// <param name="id">идентификатор</param>
        public async Task Delete(Guid id)
        {
            _doctorRepository.Delete(id);
            await _doctorRepository.SaveChangesAsync();
        }
    }
}
