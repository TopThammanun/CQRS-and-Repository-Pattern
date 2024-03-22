using CQRS_and_Repository_Pattern.CommandsAndQueries.Queries.GenderQueries;
using CQRS_and_Repository_Pattern.Database.Model.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_and_Repository_Pattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenderController : ControllerBase
    {
        private readonly IMediator mediator;

        public GenderController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<List<PcuMstGender>> GetStudentListAsync()
        {
            var studentDetails = await mediator.Send(new GetGenderListQuery());
            return studentDetails;
        }

        [HttpGet("genderId")]
        public async Task<PcuMstGender> GetStudentByIdAsync(int studentId)
        {
            var studentDetails = await mediator.Send(new GetGenderByIdQuery() { Id = studentId });
            return studentDetails;
        }
    }
}
