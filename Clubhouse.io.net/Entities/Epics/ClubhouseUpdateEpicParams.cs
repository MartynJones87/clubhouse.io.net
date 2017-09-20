using System;
using System.Collections.Generic;
using Clubhouse.io.net.Entities.Labels;
using Newtonsoft.Json;

namespace Clubhouse.io.net.Entities.Epics
{
    public class ClubhouseUpdateEpicParams
    {
        [JsonProperty(PropertyName = "after_id")]
        public long? AfterID { get; set; }

        [JsonProperty(PropertyName = "archived")]
        public bool Archived { get; set; }

        [JsonProperty(PropertyName = "before_id")]
        public long? BeforeID { get; set; }

        [JsonProperty(PropertyName = "completed_at_override")]
        public DateTime? CompletedAtOverride { get; set; }

        [JsonProperty(PropertyName = "deadline")]
        public DateTime? Deadline { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "follower_ids")]
        public List<Guid> FollowerIDs { get; set; }

        [JsonProperty(PropertyName = "labels")]
        public List<ClubhouseLabel> Labels { get; set; }

        [JsonProperty(PropertyName = "milestone_id")]
        public long? MilestoneID { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "owner_ids")]
        public List<Guid> OwnerIDs { get; set; }

        [JsonProperty(PropertyName = "started_at_override")]
        public DateTime? StartedAtOverride { get; set; }

        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }
    }
}