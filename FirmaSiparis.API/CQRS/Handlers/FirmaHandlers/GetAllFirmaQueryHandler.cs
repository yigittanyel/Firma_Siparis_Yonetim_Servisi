using DAL.DataContext;
using FirmaSiparis.API.CQRS.Queries.FirmaQueries;
using FirmaSiparis.API.CQRS.Results.FirmaResults;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;

namespace FirmaSiparis.API.CQRS.Handlers.FirmaHandlers
{
    public class GetAllFirmaQueryHandler: IRequestHandler<GetAllFirmaQuery,List<GetAllFirmaQueryResult>>
    {
        private readonly Context _dbContext;

        public GetAllFirmaQueryHandler(Context dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<GetAllFirmaQueryResult>> Handle(GetAllFirmaQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.Firmalar.Select(x => new GetAllFirmaQueryResult
            {
                FirmaAdi = x.FirmaAdi,
                OnayDurumu = x.OnayDurumu,
                SiparisIzinBaslangicSaati = (DateTime)x.SiparisIzinBaslangicSaati,
                SiparisIzinBitisSaati = (DateTime)x.SiparisIzinBitisSaati
            }).AsNoTracking().ToListAsync();
        }
    }
}
