﻿using CQRS_and_Repository_Pattern.Database.Model.Entities;
using CQRS_and_Repository_Pattern.Queries.GenderQueries;
using CQRS_and_Repository_Pattern.Repositories;
using MediatR;

namespace CQRS_and_Repository_Pattern.Handlers.GenderHandler
{
        public class GetGenderByIdHandler : IRequestHandler<GetGenderByIdQuery, PcuMstGender>
        {
        private readonly IGenderRepository _genderRepository;

        public GetGenderByIdHandler(IGenderRepository genderRepository)
        {
            _genderRepository = genderRepository;
        }

        public async Task<PcuMstGender> Handle(GetGenderByIdQuery query, CancellationToken cancellationToken)
        {
                return await _genderRepository.GetStudentByIdAsync(query.Id);
        }
    }
}
