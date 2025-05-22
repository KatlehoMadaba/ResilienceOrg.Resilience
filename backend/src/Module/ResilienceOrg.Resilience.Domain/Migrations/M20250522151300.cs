using FluentMigrator;
using Shesha.FluentMigrator;

namespace ResilienceOrg.Resilience.Domain.Migrations
{
    [Migration(20250522151300)]
   public class M20250522151300: OneWayMigration
    {
        public override void Up()
        {
            Create.Table("Res_Testimonies")
           .WithIdAsGuid()
           .WithFullAuditColumns()
           .WithColumn("Title").AsString().Nullable()
           .WithColumn("Content").AsString().Nullable()
           .WithColumn("Tags").AsString().Nullable()
           .WithColumn("IsAnonymous").AsBoolean().Nullable()
           .WithForeignKeyColumn("PersonId", "Core_Persons");
        }
    }
}
