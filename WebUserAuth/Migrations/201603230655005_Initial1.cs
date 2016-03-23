namespace WebUserAuth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Data",
                c => new
                    {
                        MyKey = c.Int(nullable: false, identity: true),
                        MyName = c.String(),
                    })
                .PrimaryKey(t => t.MyKey);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Data");
        }
    }
}
