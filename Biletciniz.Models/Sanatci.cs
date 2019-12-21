using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Biletciniz.Models
{
    public class Sanatci
    {
        public int ID { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public DateTime DogumTarihi { get; set; }

        public int SehirID { get; set; }
        [ForeignKey("SehirID")]
        public virtual Sehir Sehir { get; set; }

        public string Cinsiyet { get; set; }
        public virtual ICollection<EtkinlikSanatci> TiyatroSanatci { get; set; }
    }
}
