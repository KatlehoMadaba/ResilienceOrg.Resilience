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
    [Migration(20250520194200)]
    public class M20250520194200:Migration
    {
        /// <summary>
        /// Code to execute when executing the migrations
        /// </summary>
        public override void Up()
        {


            // Create JournalEntry table
            Create.Table("Res_JournalEntries")
                .WithIdAsGuid()
                .WithFullAuditColumns()
                .WithTenantIdAsNullable()
                .WithDiscriminator()
                .WithColumn("Content").AsString(int.MaxValue).Nullable()
                .WithColumn("EntryDate").AsDateTime().NotNullable()
                .WithColumn("Tags").AsString(1000).Nullable()
                .WithColumn("IsPrivate").AsBoolean().NotNullable().WithDefaultValue(false);

            // Add foreign key column for Person
            Alter.Table("Res_JournalEntries")
                .AddForeignKeyColumn("PersonId", "Core_Persons")
                .NotNullable();



        }

        /// <summary>
        /// Code to execute when rolling back the migration
        /// </summary>
        public override void Down()
        {



            throw new NotImplementedException("This migration has already been applied to the database and should not be rolled back.");
        }


    }
}

