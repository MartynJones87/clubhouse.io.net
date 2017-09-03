using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Clubhouse.io.net.RestAPI.Entities
{
    public class ClubhouseStorySlim
    {
        [JsonProperty(PropertyName = "archived")]
        public bool Archived { get; set; }

        [JsonProperty(PropertyName = "blocked")]
        public bool Blocked { get; set; }

        [JsonProperty(PropertyName = "blocker")]
        public bool Blocker { get; set; }

        [JsonProperty(PropertyName = "comment_ids")]
        public List<long> CommentIDs { get; set; }

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

        [JsonProperty(PropertyName = "entity_type")]
        public string EntityType { get; set; }

        [JsonProperty(PropertyName = "epic_id")]
        public int? EpicID { get; set; }

        [JsonProperty(PropertyName = "estimate")]
        public int? Estimate { get; set; }

        [JsonProperty(PropertyName = "external_id")]
        public string ExternalID { get; set; }

        [JsonProperty(PropertyName = "file_ids")]
        public List<long> FileIDs { get; set; }

        [JsonProperty(PropertyName = "follower_ids")]
        public List<Guid> FollowerIDs { get; set; }

        [JsonProperty(PropertyName = "id")]
        public long ID { get; set; }

        [JsonProperty(PropertyName = "labels")]
        public List<ClubhouseLabel> Labels { get; set; }

        [JsonProperty(PropertyName = "linked_file_ids")]
        public List<long> LinkedFileIDs { get; set; }

        [JsonProperty(PropertyName = "moved_at")]
        public DateTime? MovedAt { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "owner_ids")]
        public List<Guid> OwnerIDs { get; set; }

        [JsonProperty(PropertyName = "position")]
        public long Position { get; set; }

        [JsonProperty(PropertyName = "project_id")]
        public long ProjectID { get; set; }

        [JsonProperty(PropertyName = "requested_by_id")]
        public Guid RequestedByID { get; set; }

        [JsonProperty(PropertyName = "started")]
        public bool Started { get; set; }

        [JsonProperty(PropertyName = "started_at")]
        public DateTime? StartedAt { get; set; }

        [JsonProperty(PropertyName = "started_at_override")]
        public DateTime? StartedAtOverride { get; set; }

        [JsonProperty(PropertyName = "story_links")]
        public List<ClubhouseTypedStoryLink> StoryLinks { get; set; }

        [JsonProperty(PropertyName = "story_type")]
        public ClubhouseStoryTypes ClubhouseStoryType { get; set; }

        [JsonProperty(PropertyName = "task_ids")]
        public List<long> TaskIDs { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty(PropertyName = "workflow_state_id")]
        public long WorkflowStateID { get; set; }
    }
}