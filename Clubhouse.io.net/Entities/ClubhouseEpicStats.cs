using System;
using Newtonsoft.Json;

namespace Clubhouse.io.net.Entities
{
    public class ClubhouseEpicStats
    {
        [JsonProperty(PropertyName = "last_story_update")]
        public DateTime? LastStoryUpdate { get; set; }

        [JsonProperty(PropertyName = "num_points")]
        public int NumberOfPoints { get; set; }

        [JsonProperty(PropertyName = "num_points_done")]
        public int NumberOfPointsDone { get; set; }

        [JsonProperty(PropertyName = "num_points_started")]
        public int NumberOfPointsStarted { get; set; }

        [JsonProperty(PropertyName = "num_points_unstarted")]
        public int NumberOfPointsUnstarted { get; set; }

        [JsonProperty(PropertyName = "num_stories_done")]
        public int NumberOfStoriesDone { get; set; }

        [JsonProperty(PropertyName = "num_stories_started")]
        public int NumberOfStoriesStarted { get; set; }

        [JsonProperty(PropertyName = "num_stories_unestimated")]
        public int NumberOfStoriesUnestimated { get; set; }

        [JsonProperty(PropertyName = "num_stories_unstarted")]
        public int NumberOfStoriesUnstarted { get; set; }
    }
}