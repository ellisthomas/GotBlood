namespace GotBlood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedBloodBanks : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BloodBanks", "BloodBankName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.BloodBanks", "BloodBankName");
        }
    }
}
