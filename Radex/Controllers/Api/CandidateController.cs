namespace Radex.Controllers.Api
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Radex.Data;
    using Radex.Services.Candidate;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        private readonly ICandidateServices css;
        public CandidateController(ICandidateServices css)
        {
            this.css = css;
        }

        [HttpPost]
        public async Task<ActionResult> Post(Candidate candidate)
        {
            await this.css.PostCandidate(candidate);

            return this.CreatedAtAction("Get", new { id = candidate.Id, recruiter = candidate.Recruiter }, candidate);
        }

        [HttpGet]
        public IEnumerable<Candidate> Get()
        {
            return this.css.GetAll();

        }

        [HttpGet("{id}")]
        public ActionResult<Candidate> Get(int id)
        {
            var candidate = this.css.GetCandidate(id);

            if (candidate == null)
            {
                return this.NotFound();
            }

            return candidate;

        }

        //[HttpPut]
        //public async Task<ActionResult> Put(Candidate candidate)
        //{
        //    this.db.Entry(candidate).State = EntityState.Modified;
        //    //!!!!!!!!!! imame id i danni
        //    //nameri razlikite i kato ti kaja savechanges gi zapazi
        //    //spestqvame mapvane na proparitia
        //    await this.db.SaveChangesAsync();

        //    return this.NoContent();
        //}

        //[HttpDelete("{id}")]
        //public async Task<ActionResult> Delete(int id)
        //{
        //    var candidateForDelete = this.db
        //        .Candidates
        //        .Find(id);

        //    if (candidateForDelete == null)
        //    {
        //        return this.NotFound();
        //    }

        //    this.db.Remove(candidateForDelete);

        //    await this.db.SaveChangesAsync();

        //    return this.NoContent();
        //}
    }
}
