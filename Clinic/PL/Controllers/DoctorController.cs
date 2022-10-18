using AutoMapper;
using Clinic.BLL.Abstractions;
using Clinic.BLL.DTO;
using Clinic.PL.Models;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Clinic.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DoctorController : ControllerBase
    {
        private IDoctorService _service;
        private IMapper _mapper;
        private readonly ILogger<DoctorController> _logger;

        public DoctorController(IDoctorService service, ILogger<DoctorController> logger, IMapper mapper)
        {
            _service = service;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            return Ok(_mapper.Map<DoctorEditModel>(await _service.GetById(id)));
        }

        [HttpPost]
        public async Task<IActionResult> Add(DoctorEditModel doctor)
        {
            return Ok(await _service.Create(_mapper.Map<DoctorDTO>(doctor)));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(Guid id, DoctorEditModel doctor)
        {
            await _service.Update(id, _mapper.Map<DoctorDTO>(doctor));
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _service.Delete(id);
            return Ok();
        }

        [HttpGet("list/{sort}/{page}/{itemsPerPage}")]
        public async Task<IActionResult> GetList(int page, int itemsPerPage, string sort)
        {
            return Ok(_mapper.Map<List<DoctorModel>>(await _service.GetPaged(page, itemsPerPage, sort)));
        }
    }
}
