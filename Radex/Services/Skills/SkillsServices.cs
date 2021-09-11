namespace Radex.Services.Skills
{
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Microsoft.EntityFrameworkCore;
    using Radex.Data;
    using Radex.Models.Api;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class SkillsServices : ISkillsServices
    {
        private readonly Db db;
        private readonly IMapper mapper;

        public SkillsServices(Db db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }
        public IEnumerable GetSkills(int Id)
        {
            //var candidate = this.db.Candidates
            //     .Find(Id);

            var candidate = this.db
              .Candidates
              .Where(x => x.Id == Id)
              .ProjectTo<CandidateApiModel>(this.mapper.ConfigurationProvider)
              .AsNoTracking()
              .FirstOrDefault();

            var candidateSkills = candidate.Skills
                .Select(x => x.Name)
                .ToList();

            return candidateSkills;
        }
    }
}
