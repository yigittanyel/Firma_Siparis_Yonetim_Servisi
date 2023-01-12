using DTO.DTOs;
using EL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services.IServices
{
    public interface IFirmaService
    {
        Task<List<FirmaDTO>> GetFirmas();
        Task<FirmaDTO> GetFirma(int userId);
        Task<FirmaToAddDTO> AddFirma(FirmaToAddDTO firma);
        Task<FirmaDTO> UpdateFirma(FirmaDTO firma);
    }
}
