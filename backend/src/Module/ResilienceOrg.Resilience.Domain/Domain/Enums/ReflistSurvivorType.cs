using System.ComponentModel;
using Shesha.Domain.Attributes;

namespace ResilienceOrg.Resilience.Domain.Domain.Enums
{
    [ReferenceList("ResilienceOrg.Resilience.Domain.Domain", "Survivor")]
    public enum ReflistSurvivorType:long
    {
            [Description("PastSurvivor")]
            PastSurvivor = 1,

           [Description("ImmediateSurvivor")]
            ImmediateSurvivor = 2,

    }
}
