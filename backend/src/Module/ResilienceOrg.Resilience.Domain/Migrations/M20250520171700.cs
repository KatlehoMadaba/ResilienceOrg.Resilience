using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;

namespace ResilienceOrg.Resilience.Domain.Migrations
{
    [Migration(20250520171700)]
   public class M20250520171700: Migration
    {
        /// <summary>
        /// Code to execute when executing the migrations
        /// </summary>
        public override void Up()
        {
            // Add new columns to Core_Persons for Survivor entity
            // Note: Do not modify this since it has already been run
            Alter.Table("Core_Persons")
                .AddColumn("Res_DisplayName").AsString(255).Nullable()
                .AddColumn("Res_AnonymousId").AsString(50).Nullable()
                .AddColumn("Res_UseDisplayNameOnly").AsBoolean().Nullable()
                .AddColumn("Res_SurvivorsSexLkp").AsInt64().Nullable()
                .AddColumn("Res_IsAnonymous").AsBoolean().Nullable()
                .AddColumn("Res_IncidentDate").AsDateTime().Nullable()
                .AddColumn("Res_HasReceivedMedicalAttention").AsBoolean().NotNullable().WithDefaultValue(false)
                .AddColumn("Res_HasReportedToAuthorities").AsBoolean().NotNullable().WithDefaultValue(false);
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
    

