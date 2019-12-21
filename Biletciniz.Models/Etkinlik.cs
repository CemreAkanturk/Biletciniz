using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Biletciniz.Models
{
    public class Etkinlik
    {
        public int ID { get; set; }
        [Display(Name = "Etkinlik Adı")]
        public string EtkinlikAdi { get; set; }
        public DateTime Tarih { get; set; }
        public string Afis { get; set; }
        public int Süre { get; set; }
        [ForeignKey("Kategori")]
        public int KategoriID { get; set; }
        
        public virtual Kategori Kategori { get; set; }
        [ForeignKey("Tur")]
        public int TurID { get; set; }
        
        public virtual Tur Tur { get; set; }
        [ForeignKey("Mekan")]
        public int MekanID { get; set; }
        
        public virtual Mekan Mekan { get; set; }

        public virtual ICollection<EtkinlikSanatci> EtkinlikSanatci { get; set; }
    }
}
