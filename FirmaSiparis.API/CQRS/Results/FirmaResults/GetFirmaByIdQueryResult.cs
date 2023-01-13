namespace FirmaSiparis.API.CQRS.Results.FirmaResults
{
    public class GetFirmaByIdQueryResult
    {
        public int Id { get; set; }
        public string? FirmaAdi { get; set; }
        public bool OnayDurumu { get; set; }
        public DateTime SiparisIzinBaslangicSaati { get; set; }
        public DateTime? SiparisIzinBitisSaati { get; set; }
    }
}
