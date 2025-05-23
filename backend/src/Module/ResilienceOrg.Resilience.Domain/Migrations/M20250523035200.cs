using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;
using Shesha.FluentMigrator;

namespace ResilienceOrg.Resilience.Domain.Migrations
{
    [Migration(20250523035200)]
   public class M20250523035200:OneWayMigration
    {
        public override void Up()
        {
            Create.Table("Res_Journals")
           .WithIdAsGuid()
           .WithFullAuditColumns()
           .WithColumn("Content").AsString().Nullable()
           .WithColumn("Tags").AsString().Nullable()
           .WithColumn("EntryDate").AsDateTime().Nullable()
           .WithColumn("IsPrivate").AsBoolean().Nullable();
           //.WithForeignKeyColumn("PersonId", "Core_Persons");
        }
    }
}
