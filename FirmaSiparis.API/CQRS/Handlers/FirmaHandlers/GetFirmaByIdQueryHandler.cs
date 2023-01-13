using DAL.DataContext;
using FirmaSiparis.API.CQRS.Queries.FirmaQueries;
using FirmaSiparis.API.CQRS.Results.FirmaResults;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FirmaSiparis.API.CQRS.Handlers.FirmaHandlers
{
    public class GetFirmaByIdQueryHandler : IRequestHandler<GetFirmaByIdQuery, GetFirmaByIdQueryResult>
    {
        private readonly Context _dbContext;

        public GetFirmaByIdQueryHandler(Context dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<GetFirmaByIdQueryResult> Handle(GetFirmaByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _dbContext.Firmalar.FindAsync(request.Id);
            return new GetFirmaByIdQueryResult
            {
                Id = (int)values.Id,
                FirmaAdi = values.FirmaAdi,
                OnayDurumu = values.OnayDurumu,
                SiparisIzinBaslangicSaati = values.SiparisIzinBaslangicSaati,
                SiparisIzinBitisSaati = values.SiparisIzinBitisSaati
            };

        }
    }
}
