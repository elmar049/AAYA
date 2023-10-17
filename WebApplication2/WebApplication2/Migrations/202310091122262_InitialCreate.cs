namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Mushteris",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ShirketAdi = c.String(),
                        VOEN = c.String(),
                        AldigiXidmet = c.String(),
                        MugavileNomresi = c.String(),
                        MugavileTarixi = c.DateTime(nullable: false),
                        MonthlyPayment = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Gelirlers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Qaime = c.String(),
                        Qiymet = c.Single(nullable: false),
                        Tarix = c.DateTime(nullable: false),
                        MushteriID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Mushteris", t => t.MushteriID, cascadeDelete: true)
                .Index(t => t.MushteriID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Gelirlers", "MushteriID", "dbo.Mushteris");
            DropIndex("dbo.Gelirlers", new[] { "MushteriID" });
            DropTable("dbo.Gelirlers");
            DropTable("dbo.Mushteris");
        }
    }
}
