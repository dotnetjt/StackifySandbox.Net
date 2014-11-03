namespace HelloStackify.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Foos2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Foos", "RequiredInt", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Foos", "RequiredInt");
        }
    }
}
