using System;
using Abp.Domain.Entities.Auditing;
using ResilienceOrg.Resilience.Domain.Domain.People;


namespace ResilienceOrg.Resilience.Domain.Domain
{
    public class Testimony : FullAuditedEntity<Guid>
    {
        //public  virtual Guid RPersonId { get; set; }
        public  virtual Survivor Survivor { get; set; }
        public  virtual string Title { get; set; }
        public  virtual string Content { get; set; }
        public  virtual string Tags { get; set; }
        public virtual  bool IsAnonymous { get; set; }
    }
}
