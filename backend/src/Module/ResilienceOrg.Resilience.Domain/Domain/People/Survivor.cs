using System;
using System.ComponentModel.DataAnnotations.Schema;
using ResilienceOrg.Resilience.Domain.Domain.Enums;
using Shesha.Domain;
using Shesha.Domain.Attributes;

namespace ResilienceOrg.Resilience.Domain.Domain.People
{
    [Discriminator]
    [Table("Res_Survivor")]
    [Entity(TypeShortAlias = "Res.Survivor")]
    public class Survivor : Person
    {
        public virtual ReflistSurvivorType? SurvivorType { get; set; }//types of survivors 
        //Immediate S fields
        public virtual string? AnonymousId { get; set; }
        public virtual string? DisplayName { get; set; }
        public virtual bool? UseDisplayNameOnly { get; set; }
        public virtual bool? IsAnonymous { get; set; }
        public virtual DateTime? IncidentDate { get; set; }
        public virtual bool HasReceivedMedicalAttention { get; set; }
        public virtual bool HasReportedToAuthorities { get; set; }
        //Past S fieds 
        public virtual bool HasDisclosedBefore { get; set; }
        public virtual int TimeElapsedInDays { get; set; } // Time since incident


    }
}
