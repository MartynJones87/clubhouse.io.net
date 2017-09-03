using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Clubhouse.io.net.RestAPI.Entities
{
    public class ClubhouseCommit
    {
        [JsonProperty(PropertyName = "author_email")]
        public string AuthorEmail { get; set; }

        [JsonProperty(PropertyName = "author_id")]
        public Guid? AuthorID { get; set; }

        [JsonProperty(PropertyName = "author_identity")]
        public ClubhouseIdentity AuthorIdentity { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty(PropertyName = "entity_type")]
        public string EntityType { get; set; }

        [JsonProperty(PropertyName = "hash")]
        public string Hash { get; set; }

        [JsonProperty(PropertyName = "id")]
        public long? ID { get; set; }

        [JsonProperty(PropertyName = "merged_branch_ids")]
        public List<long> MergedBranchIDs { get; set; }

        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        [JsonProperty(PropertyName = "repository_id")]
        public long? RepositoryID { get; set; }

        [JsonProperty(PropertyName = "timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
    }
}
