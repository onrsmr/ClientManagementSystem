using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriYonetimSistemi.Database_EF_Transactions
{
    public class finansalGiderler
    {
        [Key]
        public int id { get; set; }
        public string uyeKursiyerNo { get; set; }
        public string kime { get; set; }
        public double giderTutari { get; set; }
        public DateTime giderTarihi { get; set; }
        public string giderKalemi { get; set; }
    }
}
