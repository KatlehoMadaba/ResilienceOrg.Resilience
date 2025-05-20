using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities.Auditing;
using Shesha.Domain;

namespace ResilienceOrg.Resilience.Domain.Domain
{
    public class Testimony : FullAuditedEntity<Guid>
    {
        public Guid PersonId { get; set; }
        public Person Person { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public List<string> Tags { get; set; }
        public bool IsAnonymous { get; set; }
    }
}
