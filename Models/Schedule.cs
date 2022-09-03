namespace PI2022.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public string Zaposlenik { get; set; }
        public string Posao { get; set; }
        public string? Napomena { get; set; }
        public DateTime PocetakRada { get; set; }
        public DateTime ZavrsetakRada { get; set; }
        public int BrojSati { get; set; }
        public IEnumerable<Employees>? Employees { get; set; }
        public IEnumerable<Jobs>? Jobs { get; set; }
    }
}
