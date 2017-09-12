using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Clubhouse.io.net.Entities
{
    public class ClubhouseCreateStoryParams
    {
        [JsonProperty(PropertyName = "comments")]
        public List<ClubhouseCreateCommentParams> Comments { get; set; }

        [JsonProperty(PropertyName = "completed_at_override")]
        public DateTime? CompletedAtOverride { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty(PropertyName = "deadline")]
        public DateTime? Deadline { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "epic_id")]
        public long? EpicID { get; set; }

        [JsonProperty(PropertyName = "estimate")]
        public int? Estimate { get; set; }

        [JsonProperty(PropertyName = "external_id")]
        public string ExternalID { get; set; }

        [JsonProperty(PropertyName = "file_ids")]
        public List<long> FileIDs { get; set; }

        [JsonProperty(PropertyName = "follower_ids")]
        public List<Guid> FollowerIDs { get; set; }

        [JsonProperty(PropertyName = "labels")]
        public List<ClubhouseCreateLabelParams> Labels { get; set; }

        [JsonProperty(PropertyName = "linked_file_ids")]
        public List<long> LinkedFileIDs { get; set; }

        [JsonProperty(PropertyName = "name", Required = Required.Always)]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "owner_ids")]
        public List<Guid> OwnerIDs { get; set; }

        [JsonProperty(PropertyName = "project_id", Required = Required.Always)]
        public long? ProjectID { get; set; }

        [JsonProperty(PropertyName = "requested_by_id")]
        public Guid? RequestedByID { get; set; }

        [JsonProperty(PropertyName = "story_links")]
        public List<ClubhouseCreateStoryLinkParams> StoryLinks { get; set; }

        [JsonProperty(PropertyName = "story_type")]
        public ClubhouseStoryTypes? ClubhouseStoryType { get; set; }

        [JsonProperty(PropertyName = "tasks")]
        public List<ClubhouseCreateTaskParams> Tasks { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty(PropertyName = "workflow_state_id")]
        public long? WorkflowStateID { get; set; }
    }
}