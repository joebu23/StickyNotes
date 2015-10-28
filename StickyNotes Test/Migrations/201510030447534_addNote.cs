namespace StickyNotes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNote : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Notes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        To = c.Int(nullable: false),
                        From = c.String(),
                        Body = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.To, cascadeDelete: true)
                .Index(t => t.To);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Notes", "To", "dbo.Users");
            DropIndex("dbo.Notes", new[] { "To" });
            DropTable("dbo.Notes");
        }
    }
}
