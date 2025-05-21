using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;

namespace ResilienceOrg.Resilience.Domain.Migrations
{
    [Migration(20250521162600)]
     public class M20250521162600:Migration
    {
        public override void Up()
        {
            // Rename 'Sex' column to 'SexLkp'
            Rename.Column("Sex").OnTable("Res_RPersons").To("SexLkp");

            // Rename 'RecoveryPhase' column to 'RecoveryPhaseLkp'
            Rename.Column("RecoveryPhase").OnTable("Res_RPersons").To("RecoveryPhaseLkp");
        }

        public override void Down()
        {
            // In case of rollback, revert the column names
            Rename.Column("SexLkp").OnTable("Res_RPersons").To("Sex");
            Rename.Column("RecoveryPhaseLkp").OnTable("Res_RPersons").To("RecoveryPhase");
        }
    }
}
