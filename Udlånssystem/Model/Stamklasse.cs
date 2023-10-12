using Newtonsoft.Json;

namespace Udlånssystem.Models
{
    public class StamKlasse
    {
        [JsonProperty("StamKlasseID")]
        public int StamKlasseID { get; set; }

        [JsonProperty("StamKlasse")]
        public string StamKlasseName { get; set; }
    }
}
