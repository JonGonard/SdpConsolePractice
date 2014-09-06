using Newtonsoft.Json;

namespace SdpConsolePractice.Model
{
    public class ConferenceTrack
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}