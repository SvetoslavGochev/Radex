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
    using Radex.Models.Api;
    using AutoMapper;
    using AutoMapper.QueryableExtensions;

    public class CandidateServices : ICandidateServices
    {
        private readonly Db db;
        private readonly IMapper mapper;


        public CandidateServices(Db db, IMapper mapper = null)
        {
            this.db = db;
            this.mapper = mapper;
        }
        public IEnumerable<CandidateApiModel> GetAll()
        {

            return this.db.Candidates
                .ProjectTo<CandidateApiModel>(this.mapper.ConfigurationProvider)
                .ToList();
        }
        public CandidateApiModel GetCandidate(int id)
        {
            var candidateForm = this.db
                .Candidates
                .Where(x => x.Id == id)
                .ProjectTo<CandidateApiModel>(this.mapper.ConfigurationProvider)
                .AsNoTracking()
                .FirstOrDefault();
            //check candidate form

                var candidate = this.mapper.Map<CandidateApiModel>(candidateForm);

                return candidate;
        }

        public async Task DeleteCandidate(CandidateApiModel candidate)
        {
            var deleteForm = this.mapper.Map<Candidate>(candidate);

            this.db
                .Remove(deleteForm);

            await this.db
                .SaveChangesAsync();
        }



        public async Task PostCandidate(Candidate candidate)
        {
            await this.db.Candidates
                .AddAsync(candidate);

            await this.db
                .SaveChangesAsync();
        }

        public async Task PutCandidate(CandidateApiModel candidate)
        {
            this.db.Entry(candidate)
                .State = EntityState.Modified;
            //!!!!!!!!!! imame id i danni
            //nameri razlikite i kato ti kaja savechanges gi zapazi
            //spestqvame mapvane na proparitia
            await this.db
                .SaveChangesAsync();
        }
    }
}
