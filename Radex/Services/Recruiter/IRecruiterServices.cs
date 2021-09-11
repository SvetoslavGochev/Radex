namespace Radex.Services.Recruiter
{
    using Radex.Models.Api;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public interface IRecruiterServices
    {
        IEnumerable<RecruiterApiModel> GetRecruiters();

    }
}
