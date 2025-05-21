using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;

namespace ResilienceOrg.Resilience.Domain.Migrations
{
    [Migration(20250521130200)]
    public class M20250521130200 : Migration
    {
        public override void Up()
        {
            Rename.Column("Past_HasDisclosedBefore").OnTable("Res_RPersons").To("HasDisclosedBefore");
            Rename.Column("Past_TimeElapsedInDays").OnTable("Res_RPersons").To("TimeElapsedInDays");
            Rename.Column("Past_RecoveryPhase").OnTable("Res_RPersons").To("RecoveryPhase");
            Rename.Column("Past_RecoveryPhaseText").OnTable("Res_RPersons").To("RecoveryPhaseText");
        }

        public override void Down()
        {
            Rename.Column("HasDisclosedBefore").OnTable("Res_RPersons").To("Past_HasDisclosedBefore");
            Rename.Column("TimeElapsedInDays").OnTable("Res_RPersons").To("Past_TimeElapsedInDays");
            Rename.Column("RecoveryPhase").OnTable("Res_RPersons").To("Past_RecoveryPhase");
            Rename.Column("RecoveryPhaseText").OnTable("Res_RPersons").To("Past_RecoveryPhaseText");
        }
    }
}
