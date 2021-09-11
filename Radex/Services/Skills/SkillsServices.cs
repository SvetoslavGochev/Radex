namespace Radex.Services.Skills
{
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Radex.Data;
    using Radex.Models.Api;
    using System;
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
        public IEnumerable<SkillApiModel> GetSkills(int Id)
        {
            var candidate = this.db.Candidates
                 .Where(x => x.Id == Id)
                 .FirstOrDefault();

            var candidateSkills = candidate.Skills.AsQueryable()
                .ProjectTo<SkillApiModel>(this.mapper.ConfigurationProvider)
                .ToList();

            return candidateSkills;
        }
    }
}
