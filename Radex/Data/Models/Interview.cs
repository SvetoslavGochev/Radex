using System.Collections;
using System.Collections.Generic;

namespace Radex.Data.Models
{
    public class Interview
    {
        //public Interview()
        //{
        //    this.Jobs = new HashSet<Job>();
        //}
        public int Id { get; set; }

        public int CandidateId { get; set; }
        public Candidate candidate { get; set; }

        //public IEnumerable<Job> Jobs { get; set; }
    }
}