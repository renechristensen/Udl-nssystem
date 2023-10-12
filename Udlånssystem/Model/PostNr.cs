using Newtonsoft.Json;

namespace Udlånssystem.Models
{
    public class PostNr
    {
        [JsonProperty("PostNrID")]
        public int PostNrID { get; set; }

        [JsonProperty("PostNummer")]
        public int PostNummer { get; set; }
    }
}
