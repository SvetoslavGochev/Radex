namespace Radex.Services.Candidate
{
    using Microsoft.AspNetCore.Mvc;
    using Radex.Data;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public interface ICandidateServices
    {
        Candidate GetCandidate(int id);

         Task PostCandidate(Candidate candidate);

        IEnumerable<Candidate> GetAll();

        //void PutCandidate(Candidate candidate);

    }
}
