using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Drawing.Charts;
using FluentMigrator;

namespace ResilienceOrg.Resilience.Domain.Migrations
{
    [Migration(20250521130700)]
    public class M20250521130700:Migration
    {
        public override void Up()
        {
            Alter.Table("Res_RPersons")
                .AddColumn("Profession").AsString(255).Nullable()
                .AddColumn("Organization").AsString(255).Nullable()
                .AddColumn("Credentials").AsString(255).Nullable()
                .AddColumn("IsVerified").AsBoolean().WithDefaultValue(false)
                .AddColumn("IsActive").AsBoolean().WithDefaultValue(true);

            // Ensure Discriminator column exists
            if (!Schema.Table("Res_RPersons").Column("Discriminator").Exists())
            {
                Alter.Table("Res_RPersons")
                    .AddColumn("Discriminator").AsString(100).Nullable();
            }
        }

        public override void Down()
        {
            Delete.Column("Profession").FromTable("Res_RPersons");
            Delete.Column("Organization").FromTable("Res_RPersons");
            Delete.Column("Credentials").FromTable("Res_RPersons");
            Delete.Column("IsVerified").FromTable("Res_RPersons");
            Delete.Column("IsActive").FromTable("Res_RPersons");

            // Optionally remove Discriminator if not needed anymore
            // Delete.Column("Discriminator").FromTable("Res_RPersons");
        }
    }
}

