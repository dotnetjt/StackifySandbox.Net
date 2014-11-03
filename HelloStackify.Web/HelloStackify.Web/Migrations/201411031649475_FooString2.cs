namespace HelloStackify.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FooString2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Foos", "FooString2", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Foos", "FooString2");
        }
    }
}
