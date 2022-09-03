namespace PI2022.Models
{
    public class Jobs
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string OpisPosla { get; set; }
        public int BrojOsoba { get; set; }
        public int BrojSati { get; set; }
        public int CijenaSata { get; set; }
        public string PotrebnaOprema { get; set; }
        public DateTime PocetakRadova { get; set; }
        public DateTime ZavrsetakRadova { get; set; }
        public Double Trosak { get; set; }
        public Double Profit { get; set; }
    }
}
