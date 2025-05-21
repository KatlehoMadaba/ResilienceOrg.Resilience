using System;
using ResilienceOrg.Resilience.Domain.Domain.Enums;
using Shesha.Domain.Attributes;

namespace ResilienceOrg.Resilience.Domain.Domain.RPersons
{
    [Discriminator]
    public class PastSurvivor :RPerson
    {
        public virtual DateTime? IncidentDate { get; set; }
        public virtual bool HasDisclosedBefore { get; set; }
        public virtual int TimeElapsedInDays { get; set; } // Time since incident

        [ReferenceList("Res", "RecoveryPhase")]
        public virtual ReflistRecoveryPhase? RecoveryPhase { get; set; } // Self-identified phase of recovery
        public virtual string? RecoveryPhaseText { get; set; }
    }
}
