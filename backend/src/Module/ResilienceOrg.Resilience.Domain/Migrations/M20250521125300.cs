using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Drawing.Charts;
using FluentMigrator;

namespace ResilienceOrg.Resilience.Domain.Migrations
{
    [Migration(20250521125300)]
    public class M20250521125300:Migration
    {
        public override void Up()
        {
            Alter.Table("Res_RPersons")
                .AddColumn("Past_IncidentDate").AsDateTime().Nullable()
                .AddColumn("Past_HasDisclosedBefore").AsBoolean().WithDefaultValue(false)
                .AddColumn("Past_TimeElapsedInDays").AsInt32().WithDefaultValue(0)
                .AddColumn("Past_RecoveryPhase").AsInt64().Nullable()
                .AddColumn("Past_RecoveryPhaseText").AsString(100).Nullable();
        }

        public override void Down()
        {
            Delete.Column("Past_IncidentDate").FromTable("Res_RPersons");
            Delete.Column("Past_HasDisclosedBefore").FromTable("Res_RPersons");
            Delete.Column("Past_TimeElapsedInDays").FromTable("Res_RPersons");
            Delete.Column("Past_RecoveryPhase").FromTable("Res_RPersons");
            Delete.Column("Past_RecoveryPhaseText").FromTable("Res_RPersons");
        }
    }
}

