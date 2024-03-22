using CQRS_and_Repository_Pattern.Database.Model.Entities;
using MediatR;

namespace CQRS_and_Repository_Pattern.Queries.GenderQueries
{
    public class GetGenderByIdQuery : IRequest<PcuMstGender>
    {
        public int Id { get; set; }
    }
}
