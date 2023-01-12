using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL.Entities
{
    public class Urun:BaseEntity
    {
        public Urun()
        {
            this.Siparisler = new HashSet<Siparis>();
        }
        public string? UrunAdi { get; set; }
        public int Stok { get; set; }
        public decimal Fiyat { get; set; }
        public int? FirmaId { get; set; }
        public Firma Firma { get; set; }
        public virtual ICollection<Siparis> Siparisler { get; set; }
    }
}
