namespace HelloStackify.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Foos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Foos",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FooString = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Foos");
        }
    }
}
