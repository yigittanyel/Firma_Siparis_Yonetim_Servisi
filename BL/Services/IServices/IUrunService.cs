using DTO.DTOs;
using EL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services.IServices
{
    public interface IUrunService
    {
        Task<UrunDTO> AddUrun(UrunDTO urun);
    }
}
