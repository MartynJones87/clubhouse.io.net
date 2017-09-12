using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Clubhouse.io.net.Entities
{
    public class ClubhouseProject
    {
        [JsonProperty(PropertyName = "abbreviation")]
        public string Abbreviation { get; set; }

        [JsonProperty(PropertyName = "archived")]
        public bool Archived { get; set; }

        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty(PropertyName = "days_to_themometer")]
        public int DaysToThermometer { get; set; }

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

        [JsonProperty(PropertyName = "iteration_length")]
        public int IterationLength { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "show_thermometer")]
        public bool ShowThermometer { get; set; }

        [JsonProperty(PropertyName = "start_time")]
        public DateTime? StartTime { get; set; }

        [JsonProperty(PropertyName = "stats")]
        public ClubhouseProjectStats Stats { get; set; }

        [JsonProperty(PropertyName = "team_id")]
        public int TeamID { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
}