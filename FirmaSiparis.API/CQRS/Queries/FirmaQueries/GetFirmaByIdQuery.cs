using FirmaSiparis.API.CQRS.Results.FirmaResults;
using MediatR;

namespace FirmaSiparis.API.CQRS.Queries.FirmaQueries
{
    public class GetFirmaByIdQuery:IRequest<GetFirmaByIdQueryResult>
    {
        public int Id { get; set; }

        public GetFirmaByIdQuery(int id)
        {
            Id = id;
        }
    }
}
