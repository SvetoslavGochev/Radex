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

        public async Task DeleteCandidate(Candidate candidate)
        {

            this.db
                .Remove(candidate);

            await this.db
                .SaveChangesAsync();
        }

        public IEnumerable<CandidateApiModel> GetAll()
        {
            //var b = this.db.Candidates
            //    .Select(c => new CandidateApiModel
            //    {
            //        Id = c.RecruiterId,
            //        FirstName = c.FirstName,
            //        LastName = c.LastName,
            //        Email = c.Email,
            //        publicBio = c.publicBio,
            //        BirthDate = c.BirthDate,
            //        Skills = c.Skills,

            //    })
            //    .ToList();

            return this.db.Candidates
                .ProjectTo<CandidateApiModel>(this.mapper.ConfigurationProvider)
                .ToList();
           

            
        }

        public Candidate GetCandidate(int id)
        {
            var candidate = this.db
                .Candidates
                .Find(id);

            return candidate;
        }

        public async Task PostCandidate(Candidate candidate)
        {

            await this.db.Candidates
                .AddAsync(candidate);

            await this.db
                .SaveChangesAsync();
        }

        public async Task PutCandidate(Candidate candidate)
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
