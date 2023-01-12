using BL.Services.IServices;
using DTO.DTOs;
using EL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirmaSiparis.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FirmaController : ControllerBase
    {
        private readonly IFirmaService _firmaService;
        public FirmaController(IFirmaService firmaService)
        {
            _firmaService = firmaService;
        }

        [HttpGet("getfirmas")]
        public async Task<IActionResult> GetFirmas()
        {
            try
            {
                return Ok(await _firmaService.GetFirmas());
            }
            catch (Exception)
            {
                return BadRequest("Bir hatayla karşılaşıldı!");
            }
        }

        [HttpGet("getfirma")]
        public async Task<IActionResult> GetFirma(int firmaId)
        {
            try
            {
                return Ok(await _firmaService.GetFirma(firmaId));
            }
            catch (Exception)
            {
                return BadRequest("Bir hatayla karşılaşıldı!");
            }
        }

        [HttpPost("addfirma")]
        public async Task<IActionResult> AddFirma(FirmaToAddDTO firmaDto)
        {
            try
            {
                return Ok(await _firmaService.AddFirma(firmaDto));
            }
            catch (Exception)
            {
                return BadRequest("Bir hatayla karşılaşıldı!");
            }
        }

        [HttpPut("updatefirma")]
        public async Task<IActionResult> UpdateFirma(FirmaDTO firmaDto)
        {
            try
            {
                return Ok(await _firmaService.UpdateFirma(firmaDto));
            }
            catch (Exception)
            {
                return BadRequest("Bir hatayla karşılaşıldı!");
            }
        }
    }
}
