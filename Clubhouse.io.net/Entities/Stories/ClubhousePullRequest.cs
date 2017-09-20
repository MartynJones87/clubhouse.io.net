using System;
using Newtonsoft.Json;

namespace Clubhouse.io.net.Entities.Stories
{
    public class ClubhousePullRequest
    {
        [JsonProperty(PropertyName = "branch_id")]
        public long BranchID { get; set; }

        [JsonProperty(PropertyName = "closed")]
        public bool Closed { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty(PropertyName = "entity_type")]
        public string EntityType { get; set; }

        [JsonProperty(PropertyName = "id")]
        public long ID { get; set; }

        [JsonProperty(PropertyName = "num_added")]
        public int NumberAdded { get; set; }

        [JsonProperty(PropertyName = "num_commits")]
        public int NumberCommits { get; set; }

        [JsonProperty(PropertyName = "num_modified")]
        public int NumberModified { get; set; }

        [JsonProperty(PropertyName = "num_removed")]
        public int NumberRemoved { get; set; }

        [JsonProperty(PropertyName = "number")]
        public int Number { get; set; }

        [JsonProperty(PropertyName = "target_branch_id")]
        public int TargetBranchID { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
    }
}
