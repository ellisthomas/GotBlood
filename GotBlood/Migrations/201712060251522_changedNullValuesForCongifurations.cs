namespace GotBlood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedNullValuesForCongifurations : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Location", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Location");
        }
    }
}
