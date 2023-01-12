using EL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL.Entities
{
    public class Siparis:BaseEntity
    {
        public int? FirmaId { get; set; }
        public Firma Firma { get; set; }
        public int? UrunId { get; set; }
        public Urun Urun { get; set; }
        public string SiparisiVerenMusteriAdi { get; set; }
        public DateTime SiparisTarihi { get; set; }
    }
}
