namespace Radex.Services.Candidate
{
    using Microsoft.AspNetCore.Mvc;
    using Radex.Data;
    using Radex.Models.Api;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public interface ICandidateServices
    {
        CandidateApiModel GetCandidate(int id);

         Task PostCandidate(Candidate candidate);

        IEnumerable<CandidateApiModel> GetAll();

        Task PutCandidate(CandidateApiModel candidate);

        Task DeleteCandidate(CandidateApiModel candidate);
       
    }
}
