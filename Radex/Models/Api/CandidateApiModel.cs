﻿namespace Radex.Models.Api
{
    using Radex.Data;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class CandidateApiModel
    {
        public CandidateApiModel()
        {
            this.Skills = new HashSet<SkillApiModel>();
        }
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string publicBio { get; set; }

        public string BirthDate { get; set; }

        public ICollection<SkillApiModel> Skills { get; set; }

        public int RecruiterId { get; set; }

        public RecruiterApiModel Recruiter { get; set; }
    }
}
