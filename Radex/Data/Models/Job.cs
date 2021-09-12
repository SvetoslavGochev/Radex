namespace Radex.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class Job
    {
        public int Id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public decimal salary { get; set; }
        public List<Skills> skills { get; set; }

        //public int interviewId { get; set; }
        public Interview interview { get; set; }
    }
}
