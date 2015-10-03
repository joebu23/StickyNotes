namespace StickyNotes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addKeys : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        AdminId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmailAddress = c.String(),
                        TeamId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.TeamId, cascadeDelete: true)
                .Index(t => t.TeamId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "TeamId", "dbo.Teams");
            DropIndex("dbo.Users", new[] { "TeamId" });
            DropTable("dbo.Users");
            DropTable("dbo.Teams");
        }
    }
}
