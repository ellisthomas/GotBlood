namespace GotBlood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bloodDriveUpdateForModal : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BloodDrives", "Location_Id", "dbo.BloodBanks");
            DropIndex("dbo.BloodDrives", new[] { "Location_Id" });
            AddColumn("dbo.BloodDrives", "BloodDriveName", c => c.String());
            AddColumn("dbo.BloodDrives", "BloodDriveStreetAddress", c => c.String());
            AddColumn("dbo.BloodDrives", "BloodDriveCity", c => c.String());
            AddColumn("dbo.BloodDrives", "BloodDriveState", c => c.String());
            AddColumn("dbo.BloodDrives", "BloodDriveZip", c => c.String());
            DropColumn("dbo.BloodDrives", "Location_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BloodDrives", "Location_Id", c => c.Int());
            DropColumn("dbo.BloodDrives", "BloodDriveZip");
            DropColumn("dbo.BloodDrives", "BloodDriveState");
            DropColumn("dbo.BloodDrives", "BloodDriveCity");
            DropColumn("dbo.BloodDrives", "BloodDriveStreetAddress");
            DropColumn("dbo.BloodDrives", "BloodDriveName");
            CreateIndex("dbo.BloodDrives", "Location_Id");
            AddForeignKey("dbo.BloodDrives", "Location_Id", "dbo.BloodBanks", "Id");
        }
    }
}
