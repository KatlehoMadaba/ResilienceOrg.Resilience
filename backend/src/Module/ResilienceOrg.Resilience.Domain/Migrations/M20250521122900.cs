using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Drawing.Charts;
using FluentMigrator;
using Microsoft.AspNetCore.Http.HttpResults;

namespace ResilienceOrg.Resilience.Domain.Migrations
{
    [Migration(20250521122900)]
    public class M20250521122900 : Migration
    {
        public override void Up()
        {
            Alter.Table("Res_RPersons")
                .AddColumn("IncidentDate").AsDateTime().Nullable()
                .AddColumn("HasReceivedMedicalAttention").AsBoolean().WithDefaultValue(false)
                .AddColumn("HasReportedToAuthorities").AsBoolean().WithDefaultValue(false);

            // Ensure the discriminator column exists, if not added already
            if (!Schema.Table("Res_RPersons").Column("Discriminator").Exists())
            {
                Alter.Table("Res_RPersons")
                    .AddColumn("Discriminator").AsString(100).Nullable();
            }
        }

        public override void Down()
        {
            Delete.Column("IncidentDate").FromTable("Res_RPersons");
            Delete.Column("HasReceivedMedicalAttention").FromTable("Res_RPersons");
            Delete.Column("HasReportedToAuthorities").FromTable("Res_RPersons");

            // Optionally remove Discriminator if needed
            //
        }
    }
}


