using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities.Auditing;
using Shesha.Authorization.Users;
using ResilienceOrg.Resilience.Domain.Domain.Enums;
using Shesha.Domain.Attributes;
using Shesha.Domain;

namespace ResilienceOrg.Resilience.Domain.Domain.RPersons
{
    [Discriminator]
    public class RPerson: FullAuditedEntity<Guid>
    {
        
        public virtual Guid? PersonId { get; set; }

        [ForeignKey("PersonId")]
        public virtual Shesha.Domain.Person? Person { get; set; }
        public virtual string? AnonymousId { get; set; }
        public virtual string? DisplayName { get; set; }
        public virtual bool? UseDisplayNameOnly { get; set; }
        public virtual ReflistSex? Sex { get; set; }
        public virtual string? SexText { get; set; }
        public virtual string? PhoneNumber { get; set; }
        public virtual bool? IsAnonymous { get; set; }

    }
}
