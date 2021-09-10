namespace Radex.Models.Api
{
    using Radex.Data;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;

    public class SkillResponseModels
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CandidateId { get; set; }

        [JsonIgnore]
        public Candidate Candidate { get; set; }
    }
}
