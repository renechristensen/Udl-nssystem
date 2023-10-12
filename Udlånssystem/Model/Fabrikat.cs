using Newtonsoft.Json;

namespace Udlånssystem.Models
{
    public class Fabrikat
    {
        [JsonProperty("FabrikatID")]
        public int FabrikatID { get; set; }

        [JsonProperty("Fabrikat")]
        public string FabrikatNavn { get; set; }
    }
}
