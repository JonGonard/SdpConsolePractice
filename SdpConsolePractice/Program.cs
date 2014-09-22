using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SdpConsolePractice.Model;

namespace SdpConsolePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting speakers");

            var result = GetHttpResponse(@"http://seladeveloperpractice.com/api/speakers");

            var speakers = new List<Speaker>();

            speakers = JsonConvert.DeserializeObject<List<Speaker>>("[" + result + "]");

            Console.WriteLine("Got {0} speakers", speakers.Count);
        }

        private static string GetHttpResponse(string url)
        {
            var client = new HttpClient();

            var getSpeakersTask = client.GetStringAsync(url);

            getSpeakersTask.Wait();

            return getSpeakersTask.Result;
        }
    }

    internal class Root
    {
        public List<Item> Items { get; set; }
    }

    internal class Item
    {
        public string Att1 { get; set; }
        public string Att2 { get; set; }
    }
}
