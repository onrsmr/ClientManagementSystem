using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MusteriYonetimSistemi.Database_EF_Transactions
{
    public class yeniKullaniciOlustur
    {
        public int id { get; set; }
        public string userNameSurname { get; set; }
        [Key]
        public string userName { get; set; }
        public string userPassword { get; set; }
        public string userRole { get; set; }
    }
}
