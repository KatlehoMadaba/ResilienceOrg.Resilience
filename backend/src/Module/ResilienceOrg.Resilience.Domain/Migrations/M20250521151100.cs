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
    [Migration(20250521151100)]
   public class M20250521151100:Migration
    {
        public override void Up()
        {
            // Drop foreign key and index using the old column name
            Delete.ForeignKey("FK_Res_Testimonies_Res_RPersons_PersonId").OnTable("Res_Testimonies");
            Delete.Index("IX_Res_Testimonies_PersonId").OnTable("Res_Testimonies");

            // Rename the column
            Rename.Column("PersonId").OnTable("Res_Testimonies").To("RPersonId");

            // Recreate index and foreign key with the new column name
            Create.Index("IX_Res_Testimonies_RPersonId")
            .OnTable("Res_Testimonies")
                .OnColumn("RPersonId");

            Create.ForeignKey("FK_Res_Testimonies_Res_RPersons_RPersonId")
                .FromTable("Res_Testimonies").ForeignColumn("RPersonId")
                .ToTable("Res_RPersons").PrimaryColumn("Id");
        }
        public override void Down()
        {
            Delete.ForeignKey("FK_Res_Testimonies_Res_RPersons_RPersonId").OnTable("Res_Testimonies");
            Delete.Index("IX_Res_Testimonies_RPersonId").OnTable("Res_Testimonies");

            Rename.Column("RPersonId").OnTable("Res_Testimonies").To("PersonId");

            Create.Index("IX_Res_Testimonies_PersonId")
                .OnTable("Res_Testimonies")
                .OnColumn("PersonId");

            Create.ForeignKey("FK_Res_Testimonies_Res_RPersons_PersonId")
                .FromTable("Res_Testimonies").ForeignColumn("PersonId")
                .ToTable("Res_RPersons").PrimaryColumn("Id");
        }
    }
}
