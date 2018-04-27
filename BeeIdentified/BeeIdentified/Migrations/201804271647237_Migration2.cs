namespace BeeIdentified.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Migration2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BeeDatas",
                c => new
                    {
                        BeeID = c.String(nullable: false, maxLength: 128),
                        LatinName = c.String(),
                        CommonName = c.String(),
                        ConservationStatus = c.Int(nullable: false),
                        FirstColor = c.Int(nullable: false),
                        SecondColor = c.Int(nullable: false),
                        ThirdColor = c.Int(nullable: false),
                        Fuzzy = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.BeeID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BeeDatas");
        }
    }
}
