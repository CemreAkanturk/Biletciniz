using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Biletciniz.Models
{
    public class Mekan
    {
        public int ID { get; set; }
        [Display(Name = "Mekan Adı")]
        public string MekanAdi { get; set; }
        public int Kapasite { get; set; }
        
        [ForeignKey("Sehir")]
        public int SehirID { get; set; }

       
        public virtual Sehir Sehir { get; set; }
       
        [ForeignKey("Ilce")]
        public int IlceID { get; set; }

        
        public virtual Ilce Ilce { get; set; }
    }
}
