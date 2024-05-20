namespace MusteriYonetimSistemi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init_2_for_Payments : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.aidatOdemeleris",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        uyeNo = c.String(),
                        ocakOdeme = c.String(),
                        subatOdeme = c.String(),
                        martOdeme = c.String(),
                        nisanOdeme = c.String(),
                        mayisOdeme = c.String(),
                        haziranOdeme = c.String(),
                        temmuzOdeme = c.String(),
                        agustosOdeme = c.String(),
                        eylulOdeme = c.String(),
                        ekimOdeme = c.String(),
                        kasimOdeme = c.String(),
                        aralikOdeme = c.String(),
                        eksikOdeme = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.kursOdemeleris",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        kursiyerNo = c.String(),
                        ocakOdeme = c.String(),
                        subatOdeme = c.String(),
                        martOdeme = c.String(),
                        nisanOdeme = c.String(),
                        mayisOdeme = c.String(),
                        haziranOdeme = c.String(),
                        temmuzOdeme = c.String(),
                        agustosOdeme = c.String(),
                        eylulOdeme = c.String(),
                        ekimOdeme = c.String(),
                        kasimOdeme = c.String(),
                        aralikOdeme = c.String(),
                        eksikOdeme = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.kursOdemeleris");
            DropTable("dbo.aidatOdemeleris");
        }
    }
}
