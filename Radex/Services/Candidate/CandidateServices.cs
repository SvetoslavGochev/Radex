namespace Radex.Services.Candidate
{
    using Microsoft.AspNetCore.Mvc;
    using Radex.Data;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Radex.Data;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class CandidateServices : ICandidateServices
    {
        private readonly Db db;

        public CandidateServices(Db db)
        {
            this.db = db;
        }

        public IEnumerable<Candidate> GetAll()
        {
            return db.Candidates.ToList();
        }

        public Candidate GetCandidate(int id)
        {

            var candidate = this.db.Candidates
                .Find(id);

            return candidate;
        }

        public async Task PostCandidate(Candidate candidate)
        {
            await this.db.Candidates.AddAsync(candidate);
            await this.db.SaveChangesAsync();
        }
    }
}
