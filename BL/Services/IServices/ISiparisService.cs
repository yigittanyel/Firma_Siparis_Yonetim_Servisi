using DTO.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services.IServices
{
    public interface ISiparisService
    {
        Task<SiparisDTO> AddSiparis(SiparisDTO siparis);
    }
}
