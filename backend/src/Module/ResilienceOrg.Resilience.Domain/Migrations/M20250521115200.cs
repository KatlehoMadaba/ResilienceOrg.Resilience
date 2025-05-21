using FluentMigrator;
using Shesha.FluentMigrator;

namespace ResilienceOrg.Resilience.Domain.Migrations
{
    [Migration(20250521115200)]
    public class M20250521115200 : Migration
    {
        // <summary>
        /// Code to execute when executing the migrations
        /// </summary>
        public override void Up()
        {
            // Create the RPerson table
            Create.Table("Res_RPersons")
                .WithIdAsGuid()
                .WithFullAuditColumns()
                .WithColumn("UserId").AsInt64().NotNullable()
                .WithColumn("AnonymousId").AsString(100).Nullable()
                .WithColumn("DisplayName").AsString(255).Nullable()
                .WithColumn("UseDisplayNameOnly").AsBoolean().Nullable()
                .WithColumn("Sex").AsInt64().Nullable() // For the ReflistSex enum
                .WithColumn("SexText").AsString(50).Nullable()
                .WithColumn("PhoneNumber").AsString(50).Nullable()
                .WithColumn("IsAnonymous").AsBoolean().Nullable();

            // Create foreign key to Abp.Users table (assuming standard ABP naming)
            Create.ForeignKey("FK_Res_RPersons_AbpUsers_UserId")
                .FromTable("Res_RPersons").ForeignColumn("UserId")
                .ToTable("AbpUsers").PrimaryColumn("Id");

            // Create index for UserId for better performance
            Create.Index("IX_Res_RPersons_UserId")
                .OnTable("Res_RPersons")
                .OnColumn("UserId");

            // Create index for Sex for better filtering
            Create.Index("IX_Res_RPersons_Sex")
                .OnTable("Res_RPersons")
                .OnColumn("Sex");
        }

        /// <summary>
        /// Code to execute when rolling back the migration
        /// </summary>
        public override void Down()
        {
            // Remove foreign keys
            Delete.ForeignKey("FK_Res_RPersons_AbpUsers_UserId").OnTable("Res_RPersons");

            // Remove indexes
            Delete.Index("IX_Res_RPersons_UserId").OnTable("Res_RPersons");
            Delete.Index("IX_Res_RPersons_Sex").OnTable("Res_RPersons");

            // Drop the table
            Delete.Table("Res_RPersons");
        }
    }

}
