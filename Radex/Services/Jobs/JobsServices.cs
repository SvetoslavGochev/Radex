﻿using Radex.Data;
using Radex.Models.Api;
using System.Collections.Generic;
using System.Linq;

namespace Radex.Services.Jobs
{
    public class JobsServices : IJobsServices
    {
        private readonly Db db;

        public JobsServices(Db db)
        {
            this.db = db;
        }

        public IEnumerable<CandidateApiModel> GetCandidate(string job)
        {
            var candidate = this.db.Candidates
                .Where(x => x.Skills
                .Select(x => x.Name == job))
        }
    }
}
