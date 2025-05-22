using System;
using Abp.Domain.Entities.Auditing;
using ResilienceOrg.Resilience.Domain.Domain.People;

namespace ResilienceOrg.Resilience.Domain.Domain.Journals
{

    public class JournalEntry : FullAuditedEntity<Guid>
    {
        //public virtual Guid RPersonId { get; set; }
        public virtual Survivor Survivor { get; set; }
        public virtual string Content { get; set; }
        public virtual DateTime EntryDate { get; set; }
        public virtual string Tags { get; set; }
        public virtual bool IsPrivate { get; set; }//If user allows us to publish their diary entries 
    }
}
