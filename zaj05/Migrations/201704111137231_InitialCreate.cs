namespace zaj05.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ConferenceUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        ConferenceType = c.Int(nullable: false),
                        Avatar = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            Sql(@"ALTER TABLE ConferenceUsers
ADD AvatarID [uniqueidentifier] DEFAULT NEWID() unique ROWGUIDCOL  NOT NULL;");
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ConferenceUsers");
        }
    }
}
