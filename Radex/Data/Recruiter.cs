namespace Radex.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Threading.Tasks;

    public class Recruiter
    {
        public Recruiter()
        {
            this.Candidates = new HashSet<Candidate>();
        }

        public int Id { get; init; }

        [Required]
        public string LastName { get; init; }

        [Required]
        [EmailAddress]
        public string Email { get; init; }

        [Required]
        public string Country { get; init; }

        public ICollection<Candidate> Candidates { get; set; }
    }
}
