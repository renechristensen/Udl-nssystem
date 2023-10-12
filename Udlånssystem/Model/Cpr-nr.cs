using Newtonsoft.Json;

namespace Udlånssystem.Models
{
    public class Cprnr
    {
        [JsonProperty("Cpr-nrID")]
        public int PostNrID { get; set; }

        [JsonProperty("Cpr-nr")]
        public int Cprnummer { get; set; }
    }
}
