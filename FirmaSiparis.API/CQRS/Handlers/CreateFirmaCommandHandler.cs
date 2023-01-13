using DAL.DataContext;
using EL.Entities;
using FirmaSiparis.API.CQRS.Commands.FirmaCommands;
using MediatR;

namespace FirmaSiparis.API.CQRS.Handlers
{
    public class CreateFirmaCommandHandler : IRequestHandler<CreateFirmaCommand>
    {
        private readonly Context _dbContext;

        public CreateFirmaCommandHandler(Context dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Unit> Handle(CreateFirmaCommand request, CancellationToken cancellationToken)
        {
            await _dbContext.Firmalar.AddAsync(new Firma
            {
               FirmaAdi=request.FirmaAdi,
               OnayDurumu=request.OnayDurumu,
               SiparisIzinBaslangicSaati=request.SiparisIzinBaslangicSaati,
               SiparisIzinBitisSaati=request.SiparisIzinBitisSaati
            });

            await _dbContext.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
