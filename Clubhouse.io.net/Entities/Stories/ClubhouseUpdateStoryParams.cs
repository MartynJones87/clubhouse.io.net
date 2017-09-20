using System;
using System.Collections.Generic;
using Clubhouse.io.net.Entities.Labels;
using Newtonsoft.Json;

namespace Clubhouse.io.net.Entities.Stories
{
    public class ClubhouseUpdateStoryParams
    {
        [JsonProperty(PropertyName = "after_id")]
        public long? AfterID { get; set; }

        [JsonProperty(PropertyName = "archived")]
        public bool Archived { get; set; }

        [JsonProperty(PropertyName = "before_id")]
        public long? BeforeID { get; set; }

        [JsonProperty(PropertyName = "branch_ids")]
        public List<long> BranchIDs { get; set; }

        [JsonProperty(PropertyName = "commit_ids")]
        public List<long> CommitIDs { get; set; }

        [JsonProperty(PropertyName = "completed_at_override")]
        public DateTime? CompletedAtOverride { get; set; }

        [JsonProperty(PropertyName = "deadline")]
        public DateTime? Deadline { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "epic_id")]
        public int? EpicID { get; set; }

        [JsonProperty(PropertyName = "estimate")]
        public int? Estimate { get; set; }

        [JsonProperty(PropertyName = "file_ids")]
        public List<long> FileIDs { get; set; }

        [JsonProperty(PropertyName = "follower_ids")]
        public List<Guid> FollowerIDs { get; set; }

        [JsonProperty(PropertyName = "labels")]
        public List<ClubhouseCreateLabelParams> Labels { get; set; }

        [JsonProperty(PropertyName = "linked_file_ids")]
        public List<long> LinkedFileIDs { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "owner_ids")]
        public List<Guid> OwnerIDs { get; set; }

        [JsonProperty(PropertyName = "project_id")]
        public long ProjectID { get; set; }

        [JsonProperty(PropertyName = "requested_by_id")]
        public Guid RequestedByID { get; set; }

        [JsonProperty(PropertyName = "started_at_override")]
        public DateTime? StartedAtOverride { get; set; }

        [JsonProperty(PropertyName = "story_type")]
        public ClubhouseStoryTypes StoryType { get; set; }

        [JsonProperty(PropertyName = "workflow_state_id")]
        public long WorkflowStateID { get; set; }
    }
}