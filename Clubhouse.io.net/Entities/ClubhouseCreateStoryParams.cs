using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Clubhouse.io.net.Entities
{
    public class ClubhouseCreateStoryParams
    {
        [JsonConstructor]
        public ClubhouseCreateStoryParams(
            string name,
            long projectID,
            Guid requestedByID,
            long workflowStateID,
            ClubhouseStoryTypes storyType = ClubhouseStoryTypes.Feature
        )
        {
            Name = name;
            ProjectID = projectID;
            RequestedByID = requestedByID;
            WorkflowStateID = workflowStateID;
            ClubhouseStoryType = storyType;

            InitialiseRequiredFields();
        }

        public ClubhouseCreateStoryParams(
            string name,
            ClubhouseProject project,
            ClubhouseMember requester,
            ClubhouseWorkflowState workflowState,
            ClubhouseStoryTypes storyType = ClubhouseStoryTypes.Feature
        )
        {
            Name = name;
            ProjectID = project.ID;
            RequestedByID = requester.ID;
            WorkflowStateID = workflowState.ID;
            ClubhouseStoryType = storyType;

            InitialiseRequiredFields();
        }

        private void InitialiseRequiredFields()
        {
            CompletedAtOverride = DateTime.MaxValue;
            CreatedAt = DateTime.Now;
            Description = string.Empty;
            ExternalID = string.Empty;
            FileIDs = new List<long>();
            FollowerIDs = new List<Guid>();
            LinkedFileIDs = new List<long>();
            OwnerIDs = new List<Guid>();
            UpdatedAt = DateTime.Now;
        }

        [JsonProperty(PropertyName = "comments")]
        public List<ClubhouseCreateCommentParams> Comments { get; set; }

        [JsonProperty(PropertyName = "completed_at_override", Required = Required.Always)]
        public DateTime? CompletedAtOverride { get; set; }

        [JsonProperty(PropertyName = "created_at", Required = Required.Always)]
        public DateTime CreatedAt { get; set; }

        [JsonProperty(PropertyName = "deadline")]
        public DateTime? Deadline { get; set; }

        [JsonProperty(PropertyName = "description", Required = Required.Always)]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "epic_id")]
        public long? EpicID { get; set; }

        [JsonProperty(PropertyName = "estimate")]
        public int? Estimate { get; set; }

        [JsonProperty(PropertyName = "external_id", Required = Required.Always)]
        public string ExternalID { get; set; }

        [JsonProperty(PropertyName = "file_ids", Required = Required.Always)]
        public List<long> FileIDs { get; set; }

        [JsonProperty(PropertyName = "follower_ids", Required = Required.Always)]
        public List<Guid> FollowerIDs { get; set; }

        [JsonProperty(PropertyName = "labels")]
        public List<ClubhouseCreateLabelParams> Labels { get; set; }

        [JsonProperty(PropertyName = "linked_file_ids", Required = Required.Always)]
        public List<long> LinkedFileIDs { get; set; }

        [JsonProperty(PropertyName = "name", Required = Required.Always)]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "owner_ids", Required = Required.Always)]
        public List<Guid> OwnerIDs { get; set; }

        [JsonProperty(PropertyName = "project_id", Required = Required.Always)]
        public long? ProjectID { get; set; }

        [JsonProperty(PropertyName = "requested_by_id", Required = Required.Always)]
        public Guid? RequestedByID { get; set; }

        [JsonProperty(PropertyName = "story_links")]
        public List<ClubhouseCreateStoryLinkParams> StoryLinks { get; set; }

        [JsonProperty(PropertyName = "story_type", Required = Required.Always)]
        [JsonConverter(typeof(StringEnumConverter))]
        public ClubhouseStoryTypes? ClubhouseStoryType { get; set; }

        [JsonProperty(PropertyName = "tasks")]
        public List<ClubhouseCreateTaskParams> Tasks { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty(PropertyName = "workflow_state_id", Required = Required.Always)]
        public long? WorkflowStateID { get; set; }

        public void SetOwners(List<ClubhouseMember> owners)
        {
            OwnerIDs = owners.Select(o => o.ID).ToList();
        }

        public void SetEpic(ClubhouseEpic epic)
        {
            EpicID = epic.ID;
        }
    }
}