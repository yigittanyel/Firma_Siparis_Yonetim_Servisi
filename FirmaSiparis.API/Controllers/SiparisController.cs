using BL.Services;
using BL.Services.IServices;
using DAL.DataContext;
using DTO.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Writers;

namespace FirmaSiparis.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiparisController : ControllerBase
    {
        private readonly ISiparisService _siparisService;
        private readonly Context _dbContext;
        public SiparisController(ISiparisService siparisService, Context dbContext)
        {
            _siparisService = siparisService;
            _dbContext = dbContext;
        }

        [HttpPost("addsiparis")]
        public async Task<IActionResult> AddSiparis(SiparisDTO siparisDto)
        {
            var deger = await _dbContext.Firmalar
                .Where(x=>x.Id==siparisDto.FirmaId
                && x.OnayDurumu == true 
                && x.SiparisIzinBaslangicSaati<= DateTime.Now
                && x.SiparisIzinBitisSaati>=DateTime.Now).FirstOrDefaultAsync();

            if (deger is not null)
            {
                return Ok(await _siparisService.AddSiparis(siparisDto));
            }
            else
            {
                return BadRequest("Firma onaylı değil ya da sipariş izin saatleri dışındasınız!");

            }
        }

    }
}
