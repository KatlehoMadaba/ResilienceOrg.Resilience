using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities.Auditing;
using Shesha.Domain;

namespace ResilienceOrg.Resilience.Domain.Domain.ChatSessions
{
    public class ChatMessage : FullAuditedEntity<Guid>
    {
        [Required]
        public Guid SenderPersonId { get; set; }
        public Person Sender { get; set; }

        [Required]
        public Guid ReceiverPersonId { get; set; }
        public Person Receiver { get; set; }

        [Required]
        public string Content { get; set; }

        public bool IsRead { get; set; } = false;

        public DateTime SentAt { get; set; } = DateTime.UtcNow;

        public Guid? ChatSessionId { get; set; }
    }
}
