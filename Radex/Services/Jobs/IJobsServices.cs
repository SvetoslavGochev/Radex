namespace Radex.Services
{
    using Radex.Models.Api;
    using System.Collections.Generic;

    public interface IJobsServices
    {
        IEnumerable<CandidateApiModel> GetCandidate(string job);
    }
}
