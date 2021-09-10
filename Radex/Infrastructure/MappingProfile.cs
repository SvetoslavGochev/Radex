namespace Radex.Infrastructure
{
    using AutoMapper;
    using Radex.Data;
    using Radex.Models.Api;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            this.CreateMap<CandidateApiModel, Candidate>()
                .ReverseMap();

            this.CreateMap<RecruiterApiModel, Recruiter>()
                .ReverseMap();

            this.CreateMap<SkillApiModel, Skills>()
                .ReverseMap();

            //this.CreateMap<Candidate, CandidateApiModel>()
            //.ForMember(x => x.RecruiterId, cfg => cfg.MapFrom(c => c.Id));


        }
    }
}
