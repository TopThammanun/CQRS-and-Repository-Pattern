using CQRS_and_Repository_Pattern.Database.Model.Entities;
using CQRS_and_Repository_Pattern.Queries.GenderQueries;
using CQRS_and_Repository_Pattern.Repositories;
using MediatR;

namespace CQRS_and_Repository_Pattern.Handlers.GenderHandler
{
    public class GetGenderListHandler : IRequestHandler<GetGenderListQuery, List<PcuMstGender>>
    {
        private readonly IGenderRepository _genderRepository;

        public GetGenderListHandler(IGenderRepository genderRepository)
        {
            _genderRepository = genderRepository;
        }

        public async Task<List<PcuMstGender>> Handle(GetGenderListQuery query, CancellationToken cancellationToken)
        {
            return await _genderRepository.GetStudentListAsync();
        }
    }
}
