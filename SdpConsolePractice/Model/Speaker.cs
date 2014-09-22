using System.Collections.Generic;
using Newtonsoft.Json;

namespace SdpConsolePractice.Model
{
    public class Speaker
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("photo")]
        public string Photo { get; set; }

        [JsonProperty("blog")]
        public string Blog { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("mvpprofile")]
        public string MvpProfile { get; set; }
    }
}