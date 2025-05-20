using System;
using System.Collections.Generic;
using ResilienceOrg.Resilience.Domain.Domain.Enums;
using Shesha.Domain;
using Shesha.Domain.Attributes;

namespace ResilienceOrg.Resilience.Domain.Domain
{
    [Entity(TypeShortAlias = "Res.Survivor")]
    public class Survivor : Person
    {
        public virtual string? AnonymousId { get; set; }
        public virtual string? DisplayName { get; set; }
        public virtual bool? UseDisplayNameOnly { get; set; }

        [ReferenceList("Res", "SurvivorsSex")]
        public virtual ReflistSex? SurvivorsSex { get; set; }
        public virtual bool? IsAnonymous { get; set; }
        public virtual DateTime? IncidentDate { get; set; }
        public virtual bool HasReceivedMedicalAttention { get; set; }
        public virtual bool HasReportedToAuthorities { get; set; }
        //public virtual ICollection<Testimony>? Testimonies { get; set; }
    }
}
