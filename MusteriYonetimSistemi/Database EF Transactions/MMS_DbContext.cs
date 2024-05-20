using MusteriYonetimSistemi.Database_EF_Transactions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriYonetimSistemi
{
    public class MMS_DbContext : DbContext
    {
        public DbSet<uyelikBilgileri> uyelikBilgileris { get; set; }
        public DbSet<finansalGiderler> finansalGiderlers { get; set; }
        public DbSet<finansalGelirler> finansalGelirlers { get; set; }
        public DbSet<kursiyerBilgileri> kursiyerBilgileris { get; set; }
        public DbSet<gelirKalemleri> gelirKalemleris { get; set; }
        public DbSet<giderKalemleri> giderKalemleris { get; set; }
        public DbSet<yeniKullaniciOlustur> yeniKullaniciOlusturs { get; set; }
        public DbSet<genelKayitVeIslemler> genelKayitVeIslemlers { get; set; }
        public DbSet<kursOdemeleri> kursOdemeleris { get; set; }
        public DbSet <aidatOdemeleri> aidatOdemeleris { get; set; }
    }
}
