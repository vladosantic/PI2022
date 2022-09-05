namespace PI2022.Models
{
    public class Bidding
    {
        public int Id { get; set; }

        public string Naziv { get; set; }

        public string Opis { get; set; }
        public int ProcijenjenaVrijednost { get; set; }

        public string? Trajanje { get; set; }

        public DateTime Objavljen { get; set; }

        public string? Dobitnik { get; set; }

    }
}
