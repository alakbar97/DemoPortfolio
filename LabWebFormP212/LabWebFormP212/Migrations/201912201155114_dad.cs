namespace LabWebFormP212.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dad : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IconName = c.String(nullable: false, maxLength: 30),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 30),
                        Description = c.String(nullable: false, maxLength: 110),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Pictures",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        ProjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Projects", t => t.ProjectID, cascadeDelete: true)
                .Index(t => t.ProjectID);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SiteName = c.String(nullable: false),
                        MainImage = c.String(nullable: false),
                        LinkName = c.String(nullable: false, maxLength: 100),
                        Description = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IconName = c.String(nullable: false, maxLength: 50),
                        Title = c.String(nullable: false, maxLength: 30),
                        Description = c.String(nullable: false, maxLength: 110),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Socials",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IconName = c.String(nullable: false, maxLength: 50),
                        Link = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pictures", "ProjectID", "dbo.Projects");
            DropIndex("dbo.Pictures", new[] { "ProjectID" });
            DropTable("dbo.Socials");
            DropTable("dbo.Services");
            DropTable("dbo.Projects");
            DropTable("dbo.Pictures");
            DropTable("dbo.Abouts");
            DropTable("dbo.Contacts");
        }
    }
}
