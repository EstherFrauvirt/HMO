using AutoMapper;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Services;
using DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HMO_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {

        private readonly IMemberService _memberService;
        private readonly IMapper _mapper;
        public MemberController(IMemberService memberService, IMapper mapper)
        {
            _memberService = memberService;
            _mapper = mapper;
        }

        // GET: api/<MemberController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MemberDTO>>> Get()
        {
            IEnumerable<Member> res = await _memberService.GetAllMembers();
            IEnumerable<MemberDTO> members = _mapper.Map<IEnumerable<Member>,IEnumerable< MemberDTO>>(res);
            if (members != null)
            { 
                return Ok(members);
            }
            else return StatusCode(204);
        }
        // GET api/<MemberController>/notVaccinated
        [HttpGet("notVaccinated")]
        public async Task<ActionResult<int>> GetnotVaccinated()
        {
            int count = await _memberService.peopleNotVaccinated();
            return Ok(count);
        }

        // POST api/<MemberController>
        [HttpPost]
        public async Task<ActionResult<MemberDTO>> Post([FromBody] MemberDTO value)
        {
            Member m = _mapper.Map<MemberDTO, Member>(value);
            Member res = await _memberService.addMember(m);
            MemberDTO member = _mapper.Map<Member, MemberDTO>(res);
            return CreatedAtAction(nameof(Get), new { id = member.Id }, member);

        }




    }
}
