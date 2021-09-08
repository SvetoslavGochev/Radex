namespace Radex.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class Candidate
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string publicBio { get; set; }

        [Required]
        public string BirthDate { get; set; }

        public int[] Skils = new int[] {}

        public Recruiter Recruiter { get; set; }

    }
}
