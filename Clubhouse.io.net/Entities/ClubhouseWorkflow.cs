using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Clubhouse.io.net.Entities
{
    public class ClubhouseWorkflow
    {
        [JsonProperty(PropertyName = "created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty(PropertyName = "default_state_id")]
        public long DefaultStateID { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "entity_type")]
        public string EntityType { get; set; }

        [JsonProperty(PropertyName = "id")]
        public long ID { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "states")]
        public List<ClubhouseWorkflowState> States { get; set; }

        [JsonProperty(PropertyName = "team_id")]
        public long TeamID { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
}