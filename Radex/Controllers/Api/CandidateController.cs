namespace Radex.Controllers.Api
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Radex.Data;
    using Radex.Models.Api;
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

        [HttpGet]
        public IEnumerable<CandidateApiModel> Get()
        {
            return this.css.GetAll();
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


        [HttpGet("{id}")]
        public ActionResult<CandidateApiModel> Get(int id)
        {
            var candidate = this.css.GetCandidate(id);

            var candidateExist = CandidateExist(candidate);

            if (candidateExist != null)
            {
                return candidate;
            }

            return NotFound();
        }

        [HttpPut]
        public async Task<ActionResult> Put(CandidateApiModel candidate)
        {
            await css.PutCandidate(candidate);

            return this.NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var candidateForDeleteId = css.GetCandidate(id);

            var candidateExist = CandidateExist(candidateForDeleteId);

            if (candidateExist != null)
            {
                await css.DeleteCandidate(candidateForDeleteId);

                return this.NoContent();
            }

            return NotFound();
        }

        public ActionResult<CandidateApiModel> CandidateExist(CandidateApiModel candidate)
        {
            if (candidate == null)
            {
                return null;
            }

            return candidate;
        }

        public ActionResult<CandidateApiModel> CandidateIsNull(CandidateApiModel candidate)
        {
            if (candidate == null)
            {
                return this.NotFound();
            }

            return candidate;
        }
    }

}
