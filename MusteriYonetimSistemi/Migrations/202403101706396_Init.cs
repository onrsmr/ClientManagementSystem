namespace MusteriYonetimSistemi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.finansalGelirlers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        uyeKursiyerNo = c.String(),
                        kimden = c.String(),
                        gelirTutari = c.Double(nullable: false),
                        gelirTarihi = c.DateTime(nullable: false),
                        gelirKalemi = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.finansalGiderlers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        uyeKursiyerNo = c.String(),
                        kime = c.String(),
                        giderTutari = c.Double(nullable: false),
                        giderTarihi = c.DateTime(nullable: false),
                        giderKalemi = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.gelirKalemleris",
                c => new
                    {
                        gelirID = c.Int(nullable: false, identity: true),
                        gelirAdi = c.String(),
                    })
                .PrimaryKey(t => t.gelirID);
            
            CreateTable(
                "dbo.genelKayitVeIslemlers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        kayitNo = c.String(),
                        AdiSoyadi = c.String(),
                        aciklamalar = c.String(),
                        odemeDurumu = c.String(),
                        odemeTutari = c.Double(nullable: false),
                        odemeTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.giderKalemleris",
                c => new
                    {
                        giderID = c.Int(nullable: false, identity: true),
                        giderAdi = c.String(),
                    })
                .PrimaryKey(t => t.giderID);
            
            CreateTable(
                "dbo.kursiyerBilgileris",
                c => new
                    {
                        kursiyerNo = c.String(nullable: false, maxLength: 128),
                        İd = c.Int(nullable: false),
                        kursiyerAdSoyad = c.String(),
                        kursiyerBaslangicTarihi = c.DateTime(nullable: false),
                        kursiyerSirket = c.String(),
                        kursiyerGsm = c.String(),
                        kursiyerEposta = c.String(),
                        kursiyerKisaAdres = c.String(),
                        kursiyerDogumTarihi = c.DateTime(nullable: false),
                        kursiyerAktifPasif = c.String(),
                        kursiyerAciklamalar = c.String(),
                    })
                .PrimaryKey(t => t.kursiyerNo);
            
            CreateTable(
                "dbo.uyelikBilgileris",
                c => new
                    {
                        uyeNo = c.String(nullable: false, maxLength: 128),
                        İd = c.Int(nullable: false),
                        uyeAdSoyad = c.String(),
                        uyeUyelikTarihi = c.DateTime(nullable: false),
                        uyeSirket = c.String(),
                        uyeGsm = c.String(),
                        uyeEposta = c.String(),
                        uyeKisaAdres = c.String(),
                        uyeDogumTarihi = c.DateTime(nullable: false),
                        uyeAktifPasif = c.String(),
                        uyeAciklamalar = c.String(),
                    })
                .PrimaryKey(t => t.uyeNo);
            
            CreateTable(
                "dbo.yeniKullaniciOlusturs",
                c => new
                    {
                        userName = c.String(nullable: false, maxLength: 128),
                        id = c.Int(nullable: false),
                        userNameSurname = c.String(),
                        userPassword = c.String(),
                        userRole = c.String(),
                    })
                .PrimaryKey(t => t.userName);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.yeniKullaniciOlusturs");
            DropTable("dbo.uyelikBilgileris");
            DropTable("dbo.kursiyerBilgileris");
            DropTable("dbo.giderKalemleris");
            DropTable("dbo.genelKayitVeIslemlers");
            DropTable("dbo.gelirKalemleris");
            DropTable("dbo.finansalGiderlers");
            DropTable("dbo.finansalGelirlers");
        }
    }
}
