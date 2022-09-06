namespace PI2022.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Kategorija { get; set; }
        public string Proizvodac { get; set; }
        public string Dobavljac { get; set; }
        public DateTime DatumKupnje { get; set; }
        public int Kolicina { get; set; }
        public Double NabavnaCijena { get; set; }
        public Double CijenaDostave { get; set; }
        public Double? ReferentnaCijena { get; set; }
        public IEnumerable<References>? References { get; set; }
    }
}