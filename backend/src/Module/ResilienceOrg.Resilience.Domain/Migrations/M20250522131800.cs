using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;
using Shesha.FluentMigrator;

namespace ResilienceOrg.Resilience.Domain.Migrations
{
    [Migration(20250522131800)]
    public class M20250522131800:OneWayMigration
    {
        public override void Up()
        {
            Alter.Table("Core_Persons")
           .AddColumn("Res_Profession").AsString().Nullable()
           .AddColumn("Res_Organization").AsString().Nullable()
           .AddColumn("Res_Credentials").AsString().Nullable()
           .AddColumn("Res_IsVerified").AsBoolean().Nullable()
           .AddColumn("Res_IsActive").AsBoolean().Nullable();
        }
    }
}
