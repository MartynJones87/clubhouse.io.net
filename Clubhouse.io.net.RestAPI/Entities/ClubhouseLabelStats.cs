using Newtonsoft.Json;

namespace Clubhouse.io.net.RestAPI.Entities
{
    public class ClubhouseLabelStats
    {
        [JsonProperty(PropertyName = "num_epics")]
        public int NumberOfEpics { get; set; }

        [JsonProperty(PropertyName = "num_points_completed")]
        public int NumberOfPointsCompleted { get; set; }

        [JsonProperty(PropertyName = "num_points_in_progress")]
        public int NumberOfPointsInProgress { get; set; }

        [JsonProperty(PropertyName = "num_points_total")]
        public int NumberOfPointsTotal { get; set; }

        [JsonProperty(PropertyName = "num_stories_completed")]
        public int NumberOfStoriesCompleted { get; set; }

        [JsonProperty(PropertyName = "num_stories_in_progress")]
        public int NumberOfStoriesInProgress { get; set; }

        [JsonProperty(PropertyName = "num_stories_total")]
        public int NumberOfStoriesTotal { get; set; }

        [JsonProperty(PropertyName = "num_stories_unestimated")]
        public int NumberOfStoriesUnestimated { get; set; }
    }
}