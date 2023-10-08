namespace Pharmacy_Managemnet_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ITIPharmacy : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Medications", "UnitPriceID", "dbo.DrugConcentrationPrices");
            DropIndex("dbo.Medications", new[] { "UnitPriceID" });
            AddColumn("dbo.DrugConcentrationPrices", "MedicationID", c => c.Int(nullable: false));
            CreateIndex("dbo.DrugConcentrationPrices", "MedicationID");
            AddForeignKey("dbo.DrugConcentrationPrices", "MedicationID", "dbo.Medications", "Id", cascadeDelete: false);
            DropColumn("dbo.Medications", "UnitPriceID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Medications", "UnitPriceID", c => c.Int(nullable: false));
            DropForeignKey("dbo.DrugConcentrationPrices", "MedicationID", "dbo.Medications");
            DropIndex("dbo.DrugConcentrationPrices", new[] { "MedicationID" });
            DropColumn("dbo.DrugConcentrationPrices", "MedicationID");
            CreateIndex("dbo.Medications", "UnitPriceID");
            AddForeignKey("dbo.Medications", "UnitPriceID", "dbo.DrugConcentrationPrices", "Id", cascadeDelete: false);
        }
    }
}
