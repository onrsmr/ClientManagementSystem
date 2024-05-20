using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriYonetimSistemi.Database_EF_Transactions
{
    public class kursiyerBilgileri
    {
        public int İd { get; set; }
        [Key]
        public string kursiyerNo { get; set; }
        public string kursiyerAdSoyad { get; set; }
        public DateTime kursiyerBaslangicTarihi { get; set; }
        public string kursiyerSirket { get; set; }
        public string kursiyerGsm { get; set; }
        public string kursiyerEposta { get; set; }
        public string kursiyerKisaAdres { get; set; }
        public DateTime kursiyerDogumTarihi { get; set; }
        public string kursiyerAktifPasif { get; set; }
        public string kursiyerAciklamalar { get; set; }
    }
}
