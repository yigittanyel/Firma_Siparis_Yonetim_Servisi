using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL.Entities
{
    public class Firma:BaseEntity
    {
        public Firma()
        {
            this.Uruns = new HashSet<Urun>();
            this.Siparisler = new HashSet<Siparis>();
        }
        public string? FirmaAdi { get; set; }
        public bool OnayDurumu { get; set; }
        public DateTime SiparisIzinBaslangicSaati { get; set; }
        public DateTime? SiparisIzinBitisSaati { get; set; }
        public virtual ICollection<Urun> Uruns { get; set; }
        public virtual ICollection<Siparis> Siparisler { get; set; }

    }
}
