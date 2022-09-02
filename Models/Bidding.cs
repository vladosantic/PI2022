namespace PI2022.Models
{
    public class Bidding
    {
        public int Id { get; set; }

        public string NazivNatječaja { get; set; }

        public string OpisPosla { get; set; }
        public int ProcijenjenaVrijednostPosla { get; set; }

        public string? TrajanjeNatjecaja { get; set; }

        public string Objavljen { get; set; }

        public string? DobitnikNatječaja { get; set; }

        public string ProlaznostNatječaja { get; set; }


    }
}
