using HackerNews.Framework.Interfaces;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace HackerNews.Framework.Classes
{
    public class Story : IStory
    {
        [JsonProperty("by")]
        public string By { get; set; }
        [JsonProperty("descendants")]
        public string Descendants { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("kids")]
        public List<int> Kids { get; set; }
        [JsonProperty("score")]
        public int Score { get; set; }
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("time")]
        public int Time { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }

    }
}
