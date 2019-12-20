namespace LabWebFormP212.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial5 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Projects", "LinkName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Projects", "LinkName", c => c.String(nullable: false, maxLength: 100));
        }
    }
}
