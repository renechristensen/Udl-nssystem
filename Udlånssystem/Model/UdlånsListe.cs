using Newtonsoft.Json;

namespace Udlånssystem.Models
{
    public class UdlånsListe
    {
        [JsonProperty("UdlånsListeID")]
        public int UdlånsListeID { get; set; }

        [JsonProperty("BrugerID")]
        public int BrugerID { get; set; }

        [JsonProperty("ComputerID")]
        public string Navn { get; set; }

        [JsonProperty("UdlånsDato")]
        public DateTime UdlånsDato { get; set; }
        [JsonProperty("UdløbsDato")]
        public DateTime UdløbsDato { get; set; }
    }
}
