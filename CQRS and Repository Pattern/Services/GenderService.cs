using CQRS_and_Repository_Pattern.Database;
using CQRS_and_Repository_Pattern.Database.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRS_and_Repository_Pattern.Services
{
    public interface IGenderService
    {
        public Task<List<PcuMstGender>> GenderList();
    }
    public class GenderService : IGenderService
    {
        private readonly ApplicationDbContext dbContextClass;

        public GenderService(ApplicationDbContext dbContextClass)
        {
            this.dbContextClass = dbContextClass;
        }
        public async Task<List<PcuMstGender>> GenderList()
        {
            return await dbContextClass.PcuMstGenders.ToListAsync();
        }
    }
}
