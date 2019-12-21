using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Biletciniz.Models
{
     public class Bilet
    {
        public int ID { get; set; }

        public int EtkinlikID { get; set; }
        [ForeignKey("EtkinlikID")]
        public virtual Etkinlik Etkinlik { get; set; }

        public int KoltukNo { get; set; }
        public DateTime SatisTarihi { get; set; }
        public double Fiyat { get; set; }

    }
}
