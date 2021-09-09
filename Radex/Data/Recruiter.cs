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

        public int Id { get; init; }

        [Required]
        public string LastName { get; init; }

        [Required]
        [EmailAddress]
        public string Email { get; init; }

        [Required]
        public string Country { get; init; }

        
    }
}
