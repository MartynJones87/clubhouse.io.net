using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Clubhouse.io.net.Entities
{
    public class ClubhouseMilestone
    {
        [JsonProperty(PropertyName = "categories")]
        public List<ClubhouseCategory> Categories { get; set; }

        [JsonProperty(PropertyName = "completed")]
        public bool Completed { get; set; }

        [JsonProperty(PropertyName = "completed_at")]
        public DateTime? CompletedAt { get; set; }

        [JsonProperty(PropertyName = "completed_at_override")]
        public DateTime? CompletedAtOverride { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "entity_type")]
        public string EntityType { get; set; }

        [JsonProperty(PropertyName = "id")]
        public long ID { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "position")]
        public int Position { get; set; }

        [JsonProperty(PropertyName = "started")]
        public bool Started { get; set; }

        [JsonProperty(PropertyName = "started_at")]
        public DateTime? StartedAt { get; set; }

        [JsonProperty(PropertyName = "started_at_override")]
        public DateTime? StartedAtOverride { get; set; }

        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
}
