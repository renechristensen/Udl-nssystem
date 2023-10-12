using Newtonsoft.Json;

namespace Udlånssystem.Models
{
    public class MusModel
    {
        [JsonProperty("MusTypeID")]
        public int MusTypeID { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }
    }
}
