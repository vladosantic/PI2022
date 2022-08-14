namespace PI2022.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int Kolicina { get; set; }
        public DateTime DatumKupnje { get; set; }
        public string Opis { get; set; }
    }
}