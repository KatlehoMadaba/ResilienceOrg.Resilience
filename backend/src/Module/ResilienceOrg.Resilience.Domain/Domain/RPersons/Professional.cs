namespace ResilienceOrg.Resilience.Domain.Domain.RPersons
{
    public class Professional : RPerson
    {
        public virtual string Profession { get; set; }
        public virtual string Organization { get; set; }
        public virtual string Credentials { get; set; }
        public virtual bool IsVerified { get; set; }
        public virtual bool isActive { get; set; }
    }
}
