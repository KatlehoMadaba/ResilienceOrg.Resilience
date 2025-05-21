using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Drawing.Charts;
using FluentMigrator;
using Shesha.Domain;

namespace ResilienceOrg.Resilience.Domain.Migrations
{
    [Migration(20250521160600)]
    public class M20250521160600:Migration
    {
        public override void Up()
        {
            // Add the new 'Frwk_Discriminator' column
            Alter.Table("Res_RPersons")
                .AddColumn("Frwk_Discriminator").AsString(SheshaDatabaseConsts.DiscriminatorMaxSize).Nullable();

          
            // Drop the old 'Discriminator' column
            Delete.Column("Discriminator").FromTable("Res_RPersons");
        }

        public override void Down()
        {
            // In case of rollback, revert the changes
            Alter.Table("Res_RPersons")
                .AddColumn("Discriminator").AsString(SheshaDatabaseConsts.DiscriminatorMaxSize).Nullable();

            // Optionally, if you want to move data back from 'Frwk_Discriminator' to 'Discriminator'
            Execute.Sql("UPDATE Res_RPersons SET Discriminator = Frwk_Discriminator");

            // Drop the 'Frwk_Discriminator' column
            Delete.Column("Frwk_Discriminator").FromTable("Res_RPersons");
        }
    }
}

