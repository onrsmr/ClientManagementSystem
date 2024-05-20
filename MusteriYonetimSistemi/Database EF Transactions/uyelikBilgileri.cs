using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace MusteriYonetimSistemi.Database_EF_Transactions
{
    public class uyelikBilgileri
    {
        public int İd { get; set; }
        [Key]
        public string uyeNo { get; set; }
        public string uyeAdSoyad { get; set; }
        public DateTime uyeUyelikTarihi { get; set; }
        public string uyeSirket { get; set; }
        public string uyeGsm { get; set; }
        public string uyeEposta { get; set; }
        public string uyeKisaAdres { get; set; }
        public DateTime uyeDogumTarihi { get; set; }
        public string uyeAktifPasif { get; set; }
        public string uyeAciklamalar { get; set; }
    }
}
