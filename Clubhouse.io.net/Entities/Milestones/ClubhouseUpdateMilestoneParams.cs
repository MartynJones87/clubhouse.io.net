using System;
using System.Collections.Generic;
using Clubhouse.io.net.Entities.Categories;
using Clubhouse.io.net.Entities.Workflows;
using Newtonsoft.Json;

namespace Clubhouse.io.net.Entities.Milestones
{
    public class ClubhouseUpdateMilestoneParams
    {
        [JsonProperty(PropertyName = "after_id")]
        public long AfterID { get; set; }

        [JsonProperty(PropertyName = "before")]
        public long BeforeID { get; set; }

        [JsonProperty(PropertyName = "categories")]
        public List<ClubhouseCategory> Categories { get; set; }

        [JsonProperty(PropertyName = "completed_at_override")]
        public DateTime? CompletedAtOverride { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "started_at_override")]
        public DateTime? StartedAtOverride { get; set; }

        [JsonProperty(PropertyName = "state")]
        public ClubhouseWorkflowState State { get; set; }
    }
}