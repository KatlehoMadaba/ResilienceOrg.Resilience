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

namespace ResilienceOrg.Resilience.Domain.Domain.RPersons
{
    [Discriminator]
    public class RPerson: FullAuditedEntity<Guid>
    {
        [Required]
        public long UserId { get; set; }
        [ForeignKey("UserId")]
        public User? User { get; set; }
        public string? AnonymousId { get; set; }
        public string? DisplayName { get; set; }
        public bool? UseDisplayNameOnly { get; set; }
        public virtual ReflistSex? Sex { get; set; }
        public string? SexText { get; set; }
        public string? PhoneNumber { get; set; }
        public bool? IsAnonymous { get; set; }

    }
}
