using CQRS_and_Repository_Pattern.Database.Model.Entities;
using CQRS_and_Repository_Pattern.Services;

namespace CQRS_and_Repository_Pattern.GraphQL.QueryTypes
{
    public class GenderQueryTypes
    {
        public async Task<List<PcuMstGender>> GetGenderListAsync([Service] IGenderService genderService)
        {
            return await genderService.GenderList();
        }
    }
}
