namespace BeeIdentified.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeBeeImages : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BeeDatas", "Photo", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BeeDatas", "Photo", c => c.Binary());
        }
    }
}
