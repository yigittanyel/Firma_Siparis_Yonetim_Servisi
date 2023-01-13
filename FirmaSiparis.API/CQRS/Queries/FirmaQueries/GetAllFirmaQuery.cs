using FirmaSiparis.API.CQRS.Results.FirmaResults;
using MediatR;

namespace FirmaSiparis.API.CQRS.Queries.FirmaQueries
{
    public class GetAllFirmaQuery:IRequest<List<GetAllFirmaQueryResult>>
    {

    }
}
