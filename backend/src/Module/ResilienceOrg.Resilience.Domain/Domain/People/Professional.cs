using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shesha.Domain;
using Shesha.Domain.Attributes;

namespace ResilienceOrg.Resilience.Domain.Domain.People
{
    [Discriminator]
    public class Professional : Person
    {
        public virtual string Profession { get; set; }
        public virtual string Organization { get; set; }
        public virtual string Credentials { get; set; }
        public virtual bool IsVerified { get; set; }
        public virtual bool isActive { get; set; }
    }
}
