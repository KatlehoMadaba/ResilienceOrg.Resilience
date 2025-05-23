using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities.Auditing;

namespace ResilienceOrg.Resilience.Domain.Domain.Reports
{
    public class Report : FullAuditedEntity<Guid>
    {
        public Guid PersonId { get; set; }
        public virtual Person Person { get; set; }
        public ReflistReportStatus? ReportStatus { get; set; }
        public string ReportStatusText { get; set; }
        public string? EncryptedContent { get; set; } // Encrypted report details
        public bool IsSharedWithAuthorities { get; set; }
        public DateTime? SharedDate { get; set; }
        public string? FileReference { get; set; } // For PDF generation
    }
}
