using FluentMigrator;
using Shesha.FluentMigrator;

namespace ResilienceOrg.Resilience.Domain.Migrations
{
    [Migration(20250522123400)]
   public class M20250522123400:OneWayMigration
    {
        public override void Up()
        {
            Alter.Table("Core_Persons")
           .AddColumn("Res_SurvivorTypeLkp").AsInt32().Nullable()
           .AddColumn("Res_AnonymousId").AsString().Nullable()
           .AddColumn("Res_DisplayName").AsString().Nullable()
           .AddColumn("Res_UseDisplayNameOnly").AsBoolean().Nullable()
           .AddColumn("Res_IsAnonymous").AsBoolean().Nullable()
           .AddColumn("Res_IncidentDate").AsDateTime().Nullable()
           .AddColumn("Res_HasReceivedMedicalAttention").AsBoolean().Nullable()
           .AddColumn("Res_HasReportedToAuthorities").AsBoolean().Nullable()
           .AddColumn("Res_HasDisclosedBefore").AsBoolean().Nullable()
           .AddColumn("Res_TimeElapsedInDays").AsInt32().Nullable();
        }
    }
}
