using Newtonsoft.Json;

namespace Udlånssystem.Models
{
    public class BrugerGruppe
    {
        [JsonProperty("BrugerGruppeID")]
        public int BrugerGruppeID { get; set; }

        [JsonProperty("BrugerGruppe")]
        public string BruggerGruppe { get; set; }
    }
}
