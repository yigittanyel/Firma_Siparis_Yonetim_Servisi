using MediatR;

namespace FirmaSiparis.API.CQRS.Commands.FirmaCommands
{
    public class CreateFirmaCommand : IRequest
    {
        public string FirmaAdi { get; set; }
        public bool OnayDurumu { get; set; }
        public DateTime SiparisIzinBaslangicSaati { get; set; }
        public DateTime? SiparisIzinBitisSaati { get; set; }
    }
}
