using System.Collections.Generic;
using Newtonsoft.Json;

namespace SdpConsolePractice.Model
{
    public class Description
    {
        [JsonProperty("shortdescription")]
        public string ShortDescription { get; set; }

        [JsonProperty("description")]
        public string LongDescription { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }
    }

    public class SessionTrack
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("Index")]
        public int Index { get; set; }
    }

    public class Session
    {
        [JsonProperty("day")]
        public int Day { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("speaker")]
        public string Speaker { get; set; }

        [JsonProperty("slot", IsReference = true)]
        public Slot Slot { get; set; }

        [JsonProperty("track", IsReference = true)]
        public int Track { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("prerequisites")]
        public string Prerequisites { get; set; }

        [JsonProperty("abstract")]
        public string Description { get; set; }

        [JsonProperty("num")]
        public int Id { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }
    }

    public class Slot
    {
        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("sessions", ItemIsReference = true, ItemReferenceLoopHandling = ReferenceLoopHandling.Ignore)]
        public List<Session> Sessions { get; set; }
    }

    public class Day
    {
        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("description", IsReference = true)]
        public Description Description { get; set; }

        [JsonProperty("sessionCount")]
        public int SessionCount { get; set; }

        [JsonProperty("tracks", ItemIsReference = true)]
        public List<SessionTrack> Tracks { get; set; }

        [JsonProperty("trackTitles")]
        public List<string> TrackTitles { get; set; }

        [JsonProperty("slots")]
        public List<Slot> Slots { get; set; }
    }
}