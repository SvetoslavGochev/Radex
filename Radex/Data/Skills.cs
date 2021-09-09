using System.Text.Json.Serialization;

namespace Radex.Data
{
    public class Skills
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CandidateId { get; set; }

        [JsonIgnore]
        public Candidate Candidate { get; set; }
    }
}
