namespace Radex.Services.Recruiter
{
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Radex.Data;
    using Radex.Models.Api;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class RecruiterServices : IRecruiterServices
    {
        private readonly Db db;
        private readonly IMapper mapper;

        public RecruiterServices(Db db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public IEnumerable<RecruiterApiModel> GetRecruiters()
        {

            return this.db
                .Recruiters
                .ProjectTo<RecruiterApiModel>(this.mapper.ConfigurationProvider)
                .ToList();
        }
    }
}
