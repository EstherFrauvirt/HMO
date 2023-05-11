using AutoMapper;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Services;
using DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HMO_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VaccinationController : ControllerBase
    {
       private readonly IVaccinationService _vaccinationService;
        private readonly IMapper _mapper;
        public VaccinationController(IVaccinationService vaccinationService,IMapper mapper)
        {
            _vaccinationService = vaccinationService;
            _mapper = mapper;

        }
        // GET: api/<VaccinationController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VaccinationDTO>>> Get()
        {

            IEnumerable<Vaccination> res = await _vaccinationService.getAllVaccinations();
            IEnumerable<VaccinationDTO> vaccinations = _mapper.Map<IEnumerable<Vaccination>, IEnumerable<VaccinationDTO>>(res);
          
            return Ok(vaccinations);
        }

        // GET api/<VaccinationController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<VaccinationDTO>>> Get(string id)
        {
            int n=Int32.Parse(id);
            int h=8/n;
            IEnumerable<Vaccination> res=await _vaccinationService.getVaccinationsByMemberId(id);
            IEnumerable<VaccinationDTO> vaccinations = _mapper.Map<IEnumerable<Vaccination>,IEnumerable<VaccinationDTO>>(res);
            if (vaccinations != null)
                return Ok(vaccinations);

            else
                return StatusCode(204);
        }

        // POST api/<VaccinationController>
        [HttpPost]
        public async Task<ActionResult<VaccinationDTO>> Post([FromBody] VaccinationDTO vaccination)
        {
            Vaccination value = _mapper.Map<VaccinationDTO,Vaccination>(vaccination);
            Vaccination thevaccination = (Vaccination)await _vaccinationService.addVaccination(value);
            VaccinationDTO v = _mapper.Map< Vaccination,VaccinationDTO>(thevaccination);


            return CreatedAtAction(nameof(Get), new { id = thevaccination?.Id }, thevaccination);
            
                
        }

      

      
    }
}
