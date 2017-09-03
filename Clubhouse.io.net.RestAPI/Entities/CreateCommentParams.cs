using System;
using Newtonsoft.Json;

namespace Clubhouse.io.net.RestAPI.Entities
{
    public class CreateCommentParams
    {
        [JsonProperty(PropertyName = "author_id")]
        public string AuthorID { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty(PropertyName = "external_id")]
        public long ExternalID { get; set; }

        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
}