using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Simple_API_Assessment.Data.Repository;
using Simple_API_Assessment.Models;

namespace Simple_API_Assessment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicantController : ControllerBase
    {
        private readonly IApplicantRepository applicantRepository;

        public ApplicantController(IApplicantRepository _applicantRepository)
        {
            applicantRepository = _applicantRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Applicant>>> GetAllApplicants()
        {
            var applicants = await applicantRepository.GetAllApplicants();
            return Ok(applicants);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Applicant>> GetApplicantById(int id)
        {
            var applicant = await applicantRepository.GetApplicantById(id);
            if (applicant == null)
            {
                return NotFound();
            }
            return Ok(applicant);
        }
    }
}
