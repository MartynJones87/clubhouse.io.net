using System;
using System.Collections.Generic;
using Clubhouse.io.net.Entities.Labels;
using Newtonsoft.Json;

namespace Clubhouse.io.net.Entities.Stories
{
    public class ClubhouseUpdateMultipleStoryParams
    {
        [JsonProperty(PropertyName = "after_id")]
        public long? AfterID { get; set; }

        [JsonProperty(PropertyName = "archived")]
        public bool Archived { get; set; }

        [JsonProperty(PropertyName = "before_id")]
        public long? BeforeID { get; set; }

        [JsonProperty(PropertyName = "deadline")]
        public DateTime? Deadline { get; set; }

        [JsonProperty(PropertyName = "epic_id")]
        public int? EpicID { get; set; }

        [JsonProperty(PropertyName = "estimate")]
        public int? Estimate { get; set; }

        [JsonProperty(PropertyName = "follower_ids_add")]
        public List<Guid> FollowerIDsAdd { get; set; }

        [JsonProperty(PropertyName = "follower_ids_remove")]
        public List<Guid> FollowerIDsRemove { get; set; }

        [JsonProperty(PropertyName = "labels_add")]
        public List<ClubhouseCreateLabelParams> LabelsAdd { get; set; }

        [JsonProperty(PropertyName = "labels_remove")]
        public List<ClubhouseCreateLabelParams> LabelsRemove { get; set; }

        [JsonProperty(PropertyName = "owner_ids_add")]
        public List<Guid> OwnerIDsAdd { get; set; }

        [JsonProperty(PropertyName = "owner_ids_remove")]
        public List<Guid> OwnerIDsRemove { get; set; }

        [JsonProperty(PropertyName = "project_id")]
        public long ProjectID { get; set; }

        [JsonProperty(PropertyName = "requested_by_id")]
        public Guid RequestedByID { get; set; }

        [JsonProperty(PropertyName = "story_ids", Required = Required.Always)]
        public List<long> StoryIDs { get; set; }

        [JsonProperty(PropertyName = "story_type")]
        public ClubhouseStoryTypes StoryType { get; set; }

        [JsonProperty(PropertyName = "workflow_state_id")]
        public long WorkflowStateID { get; set; }
    }
}