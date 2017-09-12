using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Clubhouse.io.net.Entities
{
    public class ClubhouseEpic
    {
        [JsonProperty(PropertyName = "archived")]
        public bool Archived { get; set; }

        [JsonProperty(PropertyName = "comments")]
        public List<ClubhouseThreadedComment> Comments { get; set; }

        [JsonProperty(PropertyName = "completed")]
        public bool Completed { get; set; }

        [JsonProperty(PropertyName = "completed_at")]
        public DateTime? CompletedAt { get; set; }

        [JsonProperty(PropertyName = "completed_at_override")]
        public DateTime? CompletedAtOverride { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty(PropertyName = "deadline")]
        public DateTime? Deadline { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "entity_type")]
        public string EntityType { get; set; }

        [JsonProperty(PropertyName = "external_id")]
        public string ExternalID { get; set; }

        [JsonProperty(PropertyName = "follower_ids")]
        public List<Guid> FollowerIDs { get; set; }

        [JsonProperty(PropertyName = "id")]
        public long ID { get; set; }

        [JsonProperty(PropertyName = "labels")]
        public List<ClubhouseLabel> Labels { get; set; }

        [JsonProperty(PropertyName = "milestone_id")]
        public long? MilestoneID { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "owner_ids")]
        public List<Guid> OwnerIDs { get; set; }

        [JsonProperty(PropertyName = "position")]
        public long Position { get; set; }

        [JsonProperty(PropertyName = "project_ids")]
        public List<int> ProjectIDs { get; set; }

        [JsonProperty(PropertyName = "started")]
        public bool Started { get; set; }

        [JsonProperty(PropertyName = "started_at")]
        public DateTime? StartedAt { get; set; }

        [JsonProperty(PropertyName = "started_at_override")]
        public DateTime? StartedAtOverride { get; set; }

        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        [JsonProperty(PropertyName = "stats")]
        public ClubhouseEpicStats Stats { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
}