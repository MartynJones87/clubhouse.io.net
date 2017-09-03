using System;
using System.Collections.Generic;
using Clubhouse.io.net.RestAPI.Entities;

namespace Clubhouse.io.net.Models
{
    public class Story
    {
        public bool Archived { get; set; }

        public bool Blocked { get; set; }

        public bool Blocker { get; set; }

        public List<Branch> Branches { get; set; }

        public List<Comment> Comments { get; set; }

        public List<Commit> Commits { get; set; }

        public bool Completed { get; set; }

        public DateTime? CompletedAt { get; set; }

        public DateTime? CompletedAtOverride { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? Deadline { get; set; }

        public string Description { get; set; }

        public string EntityType { get; set; }

        public int? EpicID { get; set; }

        public int? Estimate { get; set; }

        public string ExternalID { get; set; }

        public List<File> Files { get; set; }

        public List<Guid> FollowerIDs { get; set; }

        public List<Label> Labels { get; set; }

        public List<LinkedFile> LinkedFiles { get; set; }

        public DateTime? MovedAt { get; set; }

        public string Name { get; set; }

        public List<Guid> OwnerIDs { get; set; }

        public long Position { get; set; }

        public long ProjectID { get; set; }

        public Guid RequestedByID { get; set; }

        public bool Started { get; set; }

        public DateTime? StartedAt { get; set; }

        public DateTime? StartedAtOverride { get; set; }

        public List<StoryLink> StoryLinks { get; set; }

        public ClubhouseStoryTypes StoryType { get; set; }

        public List<Task> Tasks { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public long WorkflowStateID { get; set; }
    }
}
