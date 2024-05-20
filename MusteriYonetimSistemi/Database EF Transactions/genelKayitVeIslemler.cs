using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriYonetimSistemi.Database_EF_Transactions
{
    public class genelKayitVeIslemler
    {
        [Key]
        public int id { get; set; }
        public string kayitNo { get; set; }
        public string AdiSoyadi { get; set; }
        public string aciklamalar { get; set; }
        public string odemeDurumu { get; set; }
        public double odemeTutari { get; set; }
        public DateTime odemeTarihi { get; set; }
    }
}
