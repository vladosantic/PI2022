namespace PI2022.Models
{
    public class Employees
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public char Spol { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public DateTime ZaposlenOd { get; set; }
        public string Pozicija { get; set; }
        public string? Certifikati { get; set; }
        public Double Placa { get; set; }
        public bool Status { get; set; }
    }
}
