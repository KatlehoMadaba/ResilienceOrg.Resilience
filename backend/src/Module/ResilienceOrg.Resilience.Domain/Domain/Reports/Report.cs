using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities.Auditing;
using ResilienceOrg.Resilience.Domain.Domain.Enums;

namespace ResilienceOrg.Resilience.Domain.Domain.Reports
{
    public class Report : FullAuditedEntity<Guid>
    {
        public ReflistReportStatus? ReportStatus { get; set; }
        public string ReportStatusText { get; set; }
        public string? EncryptedContent { get; set; } // Encrypted report details
        public bool IsSharedWithAuthorities { get; set; }
        public DateTime? SharedDate { get; set; }
        public string? FileReference { get; set; } // For PDF generation
    }
}
