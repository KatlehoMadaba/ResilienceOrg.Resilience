using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;

namespace ResilienceOrg.Resilience.Domain.Migrations
{
    [Migration(20250521132600)]
    class M20250521132600 : Migration
    {
         
        public override void Up()
        {
            Alter.Column("HasDisclosedBefore").OnTable("Res_RPersons").AsBoolean().Nullable();
            Alter.Column("TimeElapsedInDays").OnTable("Res_RPersons").AsInt32().Nullable();
            Alter.Column("HasReportedToAuthorities").OnTable("Res_RPersons").AsBoolean().Nullable();
            Alter.Column("HasReceivedMedicalAttention").OnTable("Res_RPersons").AsBoolean().Nullable();
            Alter.Column("IsVerified").OnTable("Res_RPersons").AsBoolean().Nullable();
        }

        public override void Down()
        {
            // Rollback to non-nullable with default values (adjust if needed)
            Alter.Column("HasDisclosedBefore").OnTable("Res_RPersons").AsBoolean().NotNullable().WithDefaultValue(false);
            Alter.Column("TimeElapsedInDays").OnTable("Res_RPersons").AsInt32().NotNullable().WithDefaultValue(0);
            Alter.Column("HasReportedToAuthorities").OnTable("Res_RPersons").AsBoolean().NotNullable().WithDefaultValue(false);
            Alter.Column("HasReceivedMedicalAttention").OnTable("Res_RPersons").AsBoolean().NotNullable().WithDefaultValue(false);
            Alter.Column("IsVerified").OnTable("Res_RPersons").AsBoolean().NotNullable().WithDefaultValue(false);
        }
    }
}
