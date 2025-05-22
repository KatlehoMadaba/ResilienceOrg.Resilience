using System;
using ResilienceOrg.Resilience.Domain.Domain.Enums;
using Shesha.Domain.Attributes;
using Shesha.Domain.Enums;

namespace ResilienceOrg.Resilience.Common.Services.People.Dtos
{
    public class SurvivorDto
    {
        //Person
        public string? UserName { get; set; }
        public string? FirstName { get; set; }
        public string? Lastname { get; set; }
        public string? Password { get; set; }
        public string? EmailAddress1 { get; set; }
        public RefListGender? Gender { get; set; }
        public string? MobileNumber1 { get; set; }


        //Survivor
        public ReflistSurvivorType? SurvivorType { get; set; }//types of survivors 
        //ImdSurvivor
        public string? DisplayName { get; set; }
        public bool? UseDisplayNameOnly { get; set; }
        public string? AnonymousId { get; set; }
        public bool IsAnonymous { get; set; }
        public DateTime? IncidentDate { get; set; }
        public bool HasReceivedMedicalAttention { get; set; }
        public bool HasReportedToAuthorities { get; set; }
        //Past Survivor 
        public virtual bool HasDisclosedBefore { get; set; }
        public virtual int TimeElapsedInDays { get; set; } // Time since incident

        [ReferenceList("Res", "RecoveryPhase")]
        public virtual ReflistRecoveryPhase? RecoveryPhase { get; set; } // Self-identified phase of recovery
        public virtual string? RecoveryPhaseText { get; set; }
    }
}
