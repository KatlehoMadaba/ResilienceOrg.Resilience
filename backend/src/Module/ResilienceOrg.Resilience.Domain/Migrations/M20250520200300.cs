using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;
using Shesha.FluentMigrator;

namespace ResilienceOrg.Resilience.Domain.Migrations
{
    [Migration(20250520200300)]
    public class M20250520200300:Migration
    {
        public override void Up()
        {
            // Create ChatMessages table
            Create.Table("Res_ChatMessages")
                .WithIdAsGuid()
                .WithFullAuditColumns()
                .WithTenantIdAsNullable()
                .WithDiscriminator()

                // Chat message content
                .WithColumn("Content").AsString(int.MaxValue).NotNullable()

                // Read status and sent time
                .WithColumn("IsRead").AsBoolean().NotNullable().WithDefaultValue(false)
                .WithColumn("SentAt").AsDateTime().NotNullable()

                // Optional chat session ID
                .WithColumn("ChatSessionId").AsGuid().Nullable();

            // Foreign key to Sender (Person)
            Alter.Table("Res_ChatMessages")
                .AddForeignKeyColumn("SenderPersonId", "Core_Persons")
                .NotNullable();

            // Foreign key to Receiver (Person)
            Alter.Table("Res_ChatMessages")
                .AddForeignKeyColumn("ReceiverPersonId", "Core_Persons")
                .NotNullable();
        }

        public override void Down()
        {
            Delete.Table("Res_ChatMessages");
        }
    }
}
