namespace GotBlood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedBloodDrives : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BloodDrives", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BloodDrives", "Date");
        }
    }
}
