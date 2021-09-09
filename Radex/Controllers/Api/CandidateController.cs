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

            return this.CreatedAtAction("Get",
                new 
                {
                    id = candidate.Id
                },
                candidate);
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

            CandidateExist(candidate);
            return candidate;
        }

        [HttpPut]
        public async Task<ActionResult> Put(Candidate candidate)
        {
            await css.PutCandidate(candidate);

            return this.NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var candidateForDeleteId = css.GetCandidate(id);

            CandidateExist(candidateForDeleteId);

            await css.DeleteCandidate(candidateForDeleteId);

            return this.NoContent();
        }

        public  ActionResult<Candidate> CandidateExist(Candidate candidate)
        {
            if (candidate == null)
            {
                this.NotFound();
            }

            return candidate;
        }
    }

}
