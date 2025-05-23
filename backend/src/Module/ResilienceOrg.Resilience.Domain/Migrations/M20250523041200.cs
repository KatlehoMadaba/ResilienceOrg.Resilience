using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;
using Microsoft.AspNetCore.Http.HttpResults;
using Shesha.FluentMigrator;

namespace ResilienceOrg.Resilience.Domain.Migrations
{
    [Migration(20250523041200)]
    public class M20250523041200:OneWayMigration
    {
        public override void Up()
        {
            Create.Table("Res_JournalEntries")
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
