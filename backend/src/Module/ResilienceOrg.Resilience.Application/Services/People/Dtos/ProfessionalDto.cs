namespace ResilienceOrg.Resilience.Common.Services.People.Dtos
{
    public class ProfessionalDto
    {
        public virtual string Profession { get; set; }
        public virtual string Organization { get; set; }
        public virtual string Credentials { get; set; }
        public virtual bool IsVerified { get; set; }
        public virtual bool IsActive { get; set; }
    }
}
