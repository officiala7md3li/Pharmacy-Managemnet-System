namespace Pharmacy_Managemnet_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ITIPharmacy : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Users", "UserName", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", new[] { "UserName" });
        }
    }
}
