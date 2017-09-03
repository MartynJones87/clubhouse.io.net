using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Clubhouse.io.net.RestAPI.Entities
{
    public class ClubhouseBranch
    {
        [JsonProperty(PropertyName = "created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty(PropertyName = "deleted")]
        public bool Deleted { get; set; }

        [JsonProperty(PropertyName = "entity_type")]
        public string EntityType { get; set; }

        [JsonProperty(PropertyName = "id")]
        public long? ID { get; set; }

        [JsonProperty(PropertyName = "merged_branch_ids")]
        public List<long> MergedBranchIDs { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "persistent")]
        public bool Persistent { get; set; }

        [JsonProperty(PropertyName = "pull_requests")]
        public List<ClubhousePullRequest> PullRequests { get; set; }

        [JsonProperty(PropertyName = "repository_id")]
        public long? RepositoryID { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
    }
}
