using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Clubhouse.io.net.Models
{
    public class Story
    {
        [JsonProperty(PropertyName = "archived")]
        public bool Archived { get; set; }

        [JsonProperty(PropertyName = "comments")]
        public List<Comment> Comments { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty(PropertyName = "deadline")]
        public DateTime? Deadline { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "epic_id")]
        public int? EpicID { get; set; }

        [JsonProperty(PropertyName = "estimate")]
        public int? Estimate { get; set; }

        [JsonProperty(PropertyName = "file_ids")]
        public List<int> FileIDs { get; set; }

        [JsonProperty(PropertyName = "follower_ids")]
        public List<Guid> FollowerIDs { get; set; }

        [JsonProperty(PropertyName = "labels")]
        public List<Label> Labels { get; set; }

        [JsonProperty(PropertyName = "linked_file_ids")]
        public List<int> LinkedFileIDs { get; set; }

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

        [JsonProperty(PropertyName = "story_links")]
        public List<TypedStoryLink> StoryLinks { get; set; }

        [JsonProperty(PropertyName = "story_type")]
        public StoryTypes StoryType { get; set; }

        [JsonProperty(PropertyName = "tasks")]
        public List<Task> Tasks { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty(PropertyName = "workflow_state_id")]
        public long WorkflowStateID { get; set; }
    }
}