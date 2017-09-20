using System;
using System.Collections.Generic;
using Clubhouse.io.net.Entities.Files;
using Clubhouse.io.net.Entities.Labels;
using Clubhouse.io.net.Entities.LinkedFiles;
using Newtonsoft.Json;

namespace Clubhouse.io.net.Entities.Stories
{
    public class ClubhouseStory
    {
        [JsonProperty(PropertyName = "archived")]
        public bool Archived { get; set; }

        [JsonProperty(PropertyName = "blocked")]
        public bool Blocked { get; set; }

        [JsonProperty(PropertyName = "blocker")]
        public bool Blocker { get; set; }

        [JsonProperty(PropertyName = "branches")]
        public List<ClubhouseBranch> Branches { get; set; }

        [JsonProperty(PropertyName = "comments")]
        public List<ClubhouseComment> Comments { get; set; }

        [JsonProperty(PropertyName = "commits")]
        public List<ClubhouseCommit> Commits { get; set; }

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

        [JsonProperty(PropertyName = "epic_id")]
        public int? EpicID { get; set; }

        [JsonProperty(PropertyName = "estimate")]
        public int? Estimate { get; set; }

        [JsonProperty(PropertyName = "external_id")]
        public string ExternalID { get; set; }

        [JsonProperty(PropertyName = "files")]
        public List<ClubhouseFile> Files { get; set; }

        [JsonProperty(PropertyName = "follower_ids")]
        public List<Guid> FollowerIDs { get; set; }

        [JsonProperty(PropertyName = "id")]
        public long ID { get; set; }

        [JsonProperty(PropertyName = "labels")]
        public List<ClubhouseLabel> Labels { get; set; }

        [JsonProperty(PropertyName = "linked_files")]
        public List<ClubhouseLinkedFile> LinkedFiles { get; set; }

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
        public ClubhouseStoryTypes StoryType { get; set; }

        [JsonProperty(PropertyName = "tasks")]
        public List<ClubhouseTask> Tasks { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty(PropertyName = "workflow_state_id")]
        public long WorkflowStateID { get; set; }
    }
}