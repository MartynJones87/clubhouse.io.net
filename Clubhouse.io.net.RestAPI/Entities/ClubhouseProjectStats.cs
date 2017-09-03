using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Clubhouse.io.net.RestAPI.Entities
{
    public class ClubhouseProjectStats
    {
        [JsonProperty(PropertyName = "num_points")]
        public int NumberOfPoints { get; set; }

        [JsonProperty(PropertyName = "num_stories")]
        public int NumberOfStories { get; set; }
    }
}
