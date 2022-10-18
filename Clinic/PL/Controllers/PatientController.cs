using AutoMapper;
using Clinic.BLL.Abstractions;
using Clinic.BLL.DTO;
using Clinic.PL.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clinic.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatientController : ControllerBase
    {
        private IPatientService _service;
        private IMapper _mapper;
        private readonly ILogger<PatientController> _logger;

        public PatientController(IPatientService service, ILogger<PatientController> logger, IMapper mapper)
        {
            _service = service;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            return Ok(_mapper.Map<PatientEditModel>(await _service.GetById(id)));
        }

        [HttpPost]
        public async Task<IActionResult> Add(PatientEditModel patient)
        {
            return Ok(await _service.Create(_mapper.Map<PatientDTO>(patient)));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(Guid id, PatientEditModel patient)
        {
            await _service.Update(id, _mapper.Map<PatientDTO>(patient));
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
            return Ok(_mapper.Map<List<PatientModel>>(await _service.GetPaged(page, itemsPerPage,sort)));
        }
    }
}
