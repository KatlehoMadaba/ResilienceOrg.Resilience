using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shesha.Domain.Attributes;

namespace ResilienceOrg.Resilience.Domain.Domain.Enums
{
    [ReferenceList("ResilienceOrg.Resilience.Domain.Domain", "ReportStatus")]
    public enum  ReflistReportStatus:long
    {
        [Description("Submitted")]
        Submitted = 1,
        [Description("InProgress")]
        InProgress = 2,
        [Description("Draft")]
        Draft = 3
    }
}
