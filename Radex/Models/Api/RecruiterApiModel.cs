﻿namespace Radex.Models.Api
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class RecruiterApiModel
    {
        public int Id { get; set; }
        public string LastName { get; init; }

        public string Email { get; init; }
        
        public string Country { get; init; }

        public ICollection<CandidateApiModel> Candidates { get; set; }
    }
}
