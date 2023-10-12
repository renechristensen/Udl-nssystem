using Newtonsoft.Json;

namespace Udlånssystem.Models
{
    public class Bruger
    {
        [JsonProperty("BrugerID")]
        public int BrugerID { get; set; }

        [JsonProperty("BrugerGruppe")]
        public BrugerGruppe BrugerGruppe { get; set; }

        [JsonProperty("Navn")]
        public string Navn { get; set; }

        [JsonProperty("Addresse")]
        public string Addresse { get; set; }

        [JsonProperty("PostNr")]
        public PostNr PostNr { get; set; }

        [JsonProperty("Cpr-nrID")]
        public Cprnr Cprnr {get; set;}

        [JsonProperty("Email")]
        public string Email;
        [JsonProperty("StamKlasseID")]
        public StamKlasse StamKlasse { get; set; }
    }
}
