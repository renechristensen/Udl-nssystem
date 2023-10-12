using Newtonsoft.Json;

namespace Udlånssystem.Models
{
    public class Model
    {
        [JsonProperty("ModelID")]
        public int ModelID { get; set; }

        [JsonProperty("Model")]
        public string ModelNavn { get; set; }
    }
}
