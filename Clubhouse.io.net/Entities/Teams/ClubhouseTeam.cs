using System;
using System.Collections.Generic;
using Clubhouse.io.net.Entities.Workflows;
using Newtonsoft.Json;

namespace Clubhouse.io.net.Entities.Teams
{
    public class ClubhouseTeam
    {
        [JsonProperty(PropertyName = "created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "entity_type")]
        public string EntityType { get; set; }

        [JsonProperty(PropertyName = "id")]
        public long ID { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "position")]
        public long Position { get; set; }

        [JsonProperty(PropertyName = "project_ids")]
        public List<long> ProjectIDs { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty(PropertyName = "workflow")]
        public ClubhouseWorkflow Workflow { get; set; }
    }
}
