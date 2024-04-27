using Microsoft.EntityFrameworkCore;
using Simple_API_Assessment.Models;

namespace Simple_API_Assessment.Data.Repository
{
    public class ApplicantRepo : IApplicantRepository
    {
        private readonly DataContext _dbContext;

        public ApplicantRepo(DataContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Applicant>> GetAllApplicants()
        {
            var applicant = await _dbContext.Applicants.ToListAsync();
            return applicant;
        }

        public async Task<Applicant> GetApplicantById(int id)
        {
            return await _dbContext.Applicants.FirstAsync(a => a.Id == id);
        }
    }
}
