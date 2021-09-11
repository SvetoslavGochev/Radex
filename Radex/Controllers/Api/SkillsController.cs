namespace Radex.Controllers.Api
{
    using Microsoft.AspNetCore.Mvc;
    using Radex.Models.Api;
    using Radex.Services.Skills;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    [Route("skills")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        private readonly ISkillsServices skillsServices;

        public SkillsController(ISkillsServices skillsServices)
        {
            this.skillsServices = skillsServices;
        }

        [HttpGet("{Id}")]
        public IEnumerable<SkillApiModel> Get(int Id)
        {
            return this.skillsServices.GetSkills(Id);
        }
    }
}
