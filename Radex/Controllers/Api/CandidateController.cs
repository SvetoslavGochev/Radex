namespace Radex.Controllers.Api
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Radex.Data;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        private readonly Db db;
        public CandidateController(Db db)
        {
            this.db = db;
        }

        [HttpGet]
        public IEnumerable<Candidate> Get()
        {
            return db.Candidates.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Candidate> Get(int id)
        {
            var candidate = this.db.Candidates
                 .Find(id);

            if (candidate == null)
            {
                return this.NotFound();
            }

            return candidate;

        }

        [HttpPost]
        public async Task<ActionResult> Post(Candidate candidate)
        {
            await this.db.AddAsync(candidate);
            await this.db.SaveChangesAsync();

            return this.CreatedAtAction("Get", new { id = candidate.Id }, candidate);
        }

        [HttpPut]
        public async Task<ActionResult> Put(Candidate candidate)
        {
            this.db.Entry(candidate).State = EntityState.Modified;
            //!!!!!!!!!! imame id i danni
            //nameri razlikite i kato ti kaja savechanges gi zapazi
            //spestqvame mapvane na proparitia
            await this.db.SaveChangesAsync();

            return this.NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var candidateForDelete = this.db
                .Candidates
                .Find(id);

            if (candidateForDelete == null)
            {
                return this.NotFound();
            }

            this.db.Remove(candidateForDelete);

            await this.db.SaveChangesAsync();

            return this.NoContent();
        }
    }
}
