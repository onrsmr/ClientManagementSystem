using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusteriYonetimSistemi.Database_EF_Transactions
{
    public class finansalGelirler
    {
        [Key]
        public int id { get; set; }
        public string uyeKursiyerNo { get; set; }
        public string kimden { get; set; }
        public double gelirTutari { get; set; }
        public DateTime gelirTarihi { get; set; }
        public string gelirKalemi { get; set; }

    }
}
