using System;
using Newtonsoft.Json;

namespace Clubhouse.io.net.Models
{
    public class LabelWithCounts
    {
        [JsonProperty(PropertyName = "created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty(PropertyName = "id")]
        public long ID { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "num_stories_completed")]
        public long NumberOfStoriesCompleted { get; set; }

        [JsonProperty(PropertyName = "num_stories_in_progress")]
        public long NumberOfStoriesInProgress { get; set; }

        [JsonProperty(PropertyName = "num_stories_total")]
        public long NumberOfStoriesInTotal { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}