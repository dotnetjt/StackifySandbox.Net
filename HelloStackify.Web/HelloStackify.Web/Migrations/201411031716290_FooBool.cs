namespace HelloStackify.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FooBool : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Foos", "FooBool", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Foos", "FooBool");
        }
    }
}
