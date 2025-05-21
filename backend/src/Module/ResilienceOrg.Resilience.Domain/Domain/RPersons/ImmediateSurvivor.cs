using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResilienceOrg.Resilience.Domain.Domain;
using Shesha.Domain.Attributes;

namespace ResilienceOrg.Resilience.Domain.Domain.RPersons
{
    [Discriminator]
    public class ImmediateSurvivor : RPerson
    {
        public virtual DateTime? IncidentDate { get; set; }
        public virtual bool HasReceivedMedicalAttention { get; set; }
        public virtual bool HasReportedToAuthorities { get; set; }
        public virtual ICollection<Testimony>? Testimonies { get; set; }

    }
}
