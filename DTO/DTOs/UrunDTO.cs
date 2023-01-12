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
    public class UrunDTO
    {
        public string? UrunAdi { get; set; }
        public int Stok { get; set; }
        public decimal Fiyat { get; set; }
        public int? FirmaId { get; set; }
    }
}
