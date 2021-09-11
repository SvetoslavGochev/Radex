namespace Radex.Controllers.Api
{
    using Microsoft.AspNetCore.Mvc;
    using Radex.Data;
    using Radex.Models.Api;
    using Radex.Services.Recruiter;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    [Route("[controller]")]
    [ApiController]
    public class RecruitersController : ControllerBase
    {
        private readonly IRecruiterServices rss;

        public RecruitersController(IRecruiterServices rss)
        {
            this.rss = rss;
        }

        [HttpGet]
        public IEnumerable<RecruiterApiModel> GetRecruiters()
        {
          return  this.rss.GetRecruiters();
        }
    }
}
