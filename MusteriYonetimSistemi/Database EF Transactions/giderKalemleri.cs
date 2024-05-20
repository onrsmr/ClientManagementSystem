using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriYonetimSistemi.Database_EF_Transactions
{
    public class giderKalemleri
    {
        [Key]
        public int giderID { get; set; }
        public string giderAdi { get; set; }
    }
}
