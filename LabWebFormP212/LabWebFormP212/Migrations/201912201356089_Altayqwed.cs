namespace LabWebFormP212.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Altayqwed : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Projects", "Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Projects", "Description", c => c.String(nullable: false, maxLength: 500));
        }
    }
}
