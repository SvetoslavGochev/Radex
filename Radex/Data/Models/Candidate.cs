namespace Radex.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;

    public class Candidate
    {
        public Candidate()
        {
            this.Skills = new HashSet<Skills>();
        }
        public int Id { get; set; }


        public string FirstName { get; set; }


        public string LastName { get; set; }


        public string Email { get; set; }


        public string publicBio { get; set; }

        public string BirthDate { get; set; }


        public ICollection<Skills> Skills { get; set; }

        public int RecruiterId { get; set; }
        //imame control varhu nego int? za da sazdadem candidat bez recruiter
        public Recruiter Recruiter { get; set; } 

    }
}
