using Newtonsoft.Json;

namespace Udlånssystem.Models
{
    public class Computer
    {
        [JsonProperty("ComputerID")]
        public int ComputerID { get; set; }

        [JsonProperty("FabrikatID")]
        public Fabrikat FabrikatID { get; set; }

        [JsonProperty("ModelID")]
        public int ModelID { get; set; }

        [JsonProperty("Computernummer")]
        public int Computernummer { get; set; }
        [JsonProperty("MusTypeID")]
        public int MusTypeID { get; set; }
    }
}
