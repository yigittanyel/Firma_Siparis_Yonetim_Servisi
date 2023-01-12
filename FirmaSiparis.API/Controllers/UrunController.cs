using BL.Services;
using BL.Services.IServices;
using DTO.DTOs;
using EL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirmaSiparis.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UrunController : ControllerBase
    {
        private readonly IUrunService _urunService;

        public UrunController(IUrunService urunService)
        {
            _urunService = urunService;
        }
        [HttpPost("addurun")]
        public async Task<IActionResult> AddUrun(UrunDTO urunDto)
        {
            try
            {
                return Ok(await _urunService.AddUrun(urunDto));
            }
            catch (Exception)
            {
                return BadRequest("Bir hatayla karşılaşıldı!");
            }
        }
    }
}
