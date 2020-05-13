using Clubhouse.io.net.Entities.Stories;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Clubhouse.io.net.Entities.Search.Stories
{
    public class ClubhouseStorySearchResults
    {
        [JsonProperty(PropertyName = "cursors")]
        public List<string> Cursors { get; set; }

        [JsonProperty(PropertyName = "data")]
        public List<ClubhouseStory> Data { get; set; }

        [JsonProperty(PropertyName = "next")]
        public string Next { get; set; }

        [JsonProperty(PropertyName = "total")]
        public long Total { get; set; }
    }
}
