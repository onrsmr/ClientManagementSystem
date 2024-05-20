using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriYonetimSistemi.Database_EF_Transactions
{
    public class gelirKalemleri
    {
        [Key]
        public int gelirID { get; set; }
        public string gelirAdi { get; set; }
    }
}
