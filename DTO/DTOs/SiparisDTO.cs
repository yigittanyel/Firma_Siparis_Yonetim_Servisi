using EL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOs
{
    public class SiparisDTO
    {
        public int? FirmaId { get; set; }
        public int? UrunId { get; set; }
        public string SiparisiVerenMusteriAdi { get; set; }
        public DateTime SiparisTarihi { get; set; }
    }
}
