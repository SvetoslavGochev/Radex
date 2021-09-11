namespace Radex.Services.Skills
{
    using Radex.Models.Api;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public interface ISkillsServices
    {
        IEnumerable GetSkills(int Id);
    }
}
