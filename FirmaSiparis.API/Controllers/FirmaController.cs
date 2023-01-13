using BL.Services.IServices;
using DTO.DTOs;
using EL.Entities;
using FirmaSiparis.API.CQRS.Commands.FirmaCommands;
using FirmaSiparis.API.CQRS.Queries.FirmaQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirmaSiparis.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FirmaController : ControllerBase
    {
        private readonly IFirmaService _firmaService;
        private readonly IMediator _mediator;
        public FirmaController(IFirmaService firmaService, IMediator mediator)
        {
            _firmaService = firmaService;
            _mediator = mediator;
        }

        [HttpGet("getfirmas")]
        public async Task<IActionResult> GetFirmas()
        {
            try
            {
                var values = await _mediator.Send(new GetAllFirmaQuery());
                return Ok(values);
            }
            catch (Exception)
            {
                return BadRequest("Bir hatayla karşılaşıldı!");
            }
        }

        [HttpGet("getfirma")]
        public async Task<IActionResult> GetFirma(int firmaId)
        {
            var values = await _mediator.Send(new GetFirmaByIdQuery(firmaId));
            return Ok(values);
        }

        [HttpPost("addfirma")]
        public async Task<IActionResult> AddFirma(CreateFirmaCommand command)
        {
            try
            {
               var values= await _mediator.Send(command);
                return Ok(values);
            }
            catch (Exception)
            {
                return BadRequest("Bir hatayla karşılaşıldı!");
            }
        }

        //[HttpPost("addfirma")]
        //public async Task<IActionResult> AddFirma(FirmaToAddDTO firmaDto)
        //{
        //    try
        //    {
        //        return Ok(await _firmaService.AddFirma(firmaDto));
        //    }
        //    catch (Exception)
        //    {
        //        return BadRequest("Bir hatayla karşılaşıldı!");
        //    }
        //}

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
