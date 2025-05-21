using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities.Auditing;
using ResilienceOrg.Resilience.Domain.Domain.RPersons;
using Shesha.Domain;

namespace ResilienceOrg.Resilience.Domain.Domain.Journals
{

    public class JournalEntry : FullAuditedEntity<Guid>
    {
        public virtual Guid RPersonId { get; set; }
        public virtual RPerson RPerson { get; set; }
        public virtual string Content { get; set; }
        public virtual DateTime EntryDate { get; set; }
        public virtual string Tags { get; set; }
        public virtual bool IsPrivate { get; set; }//If user allows us to publish their diary entries 
    }
}
