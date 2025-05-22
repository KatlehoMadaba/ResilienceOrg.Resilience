using System.ComponentModel;
using Shesha.Domain.Attributes;

namespace ResilienceOrg.Resilience.Domain.Domain.Enums
{
    /// <summary>
    /// Sex for a Survivors 
    /// </summary>
    [ReferenceList("ResilienceOrg.Resilience.Domain.Domain", "Sex")]
    public enum ReflistSex : long
    {
        [Description(" Male")]
        Male = 1,
        [Description("Female")]
        Female = 2,
        [Description("PreferNotToSay")]
        PreferNotToSay = 3,

    }
}
