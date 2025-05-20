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
    [Migration(20250520195300)]
   public  class M20250520195300:Migration
    {
        /// <summary>
        /// Code to execute when executing the migrations
        /// </summary>
        /// <summary>
        /// Code to execute when executing the migrations
        /// </summary>
        public override void Up()
        {
            // Create the Testimonies table
            Create.Table("Res_Testimonies")
                .WithIdAsGuid()
                .WithFullAuditColumns()
                .WithTenantIdAsNullable()
                .WithDiscriminator()
                .WithColumn("PersonId").AsGuid().NotNullable()
                .WithColumn("Title").AsString(256).Nullable()
                .WithColumn("Content").AsString(int.MaxValue).Nullable()
                .WithColumn("Tags").AsString(1000).Nullable()
                .WithColumn("IsAnonymous").AsBoolean().NotNullable().WithDefaultValue(false);

            // Create foreign key to Core_Persons table
            Create.ForeignKey("FK_Res_Testimonies_Core_Persons_PersonId")
                .FromTable("Res_Testimonies").ForeignColumn("PersonId")
                .ToTable("Core_Persons").PrimaryColumn("Id");

            // Create index for better performance
            Create.Index("IX_Res_Testimonies_PersonId")
                .OnTable("Res_Testimonies")
                .OnColumn("PersonId");
        }

        /// <summary>
        /// Code to execute when rolling back the migration
        /// </summary>
        public override void Down()
        {
            // Since the migration has already been run, implement this method
            // but ensure it's never accidentally called as it would cause data loss
            throw new NotImplementedException("This migration has already been applied to the database and should not be rolled back.");
        }


    }
}
