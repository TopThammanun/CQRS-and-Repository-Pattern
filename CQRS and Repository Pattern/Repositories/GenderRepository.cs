using CQRS_and_Repository_Pattern.Database;
using CQRS_and_Repository_Pattern.Database.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRS_and_Repository_Pattern.Repositories
{
    public interface IGenderRepository
    {
        public Task<List<PcuMstGender>> GetStudentListAsync();
        public Task<PcuMstGender> GetStudentByIdAsync(int Id);
        public Task<PcuMstGender> AddStudentAsync(PcuMstGender genderData);
        public Task<int> UpdateStudentAsync(PcuMstGender genderData);
        public Task<int> DeleteStudentAsync(int Id);
    }
    public class GenderRepository : IGenderRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public GenderRepository(ApplicationDbContext dbContextClass)
        {
            this._dbContext = dbContextClass;
        }
        public async Task<PcuMstGender> AddStudentAsync(PcuMstGender studentDetails)
        {
            var result = _dbContext.PcuMstGenders.Add(studentDetails);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<int> DeleteStudentAsync(int Id)
        {
            var filteredData = _dbContext.PcuMstGenders.Where(x => x.GEND_ID == Id).FirstOrDefault();
            _dbContext.PcuMstGenders.Remove(filteredData);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<PcuMstGender> GetStudentByIdAsync(int Id)
        {
            return await _dbContext.PcuMstGenders.Where(x => x.GEND_ID == Id).FirstOrDefaultAsync();
        }

        public async Task<List<PcuMstGender>> GetStudentListAsync()
        {
            return await _dbContext.PcuMstGenders.ToListAsync();
        }

        public async Task<int> UpdateStudentAsync(PcuMstGender studentDetails)
        {
            _dbContext.PcuMstGenders.Update(studentDetails);
            return await _dbContext.SaveChangesAsync();
        }
    }
}
