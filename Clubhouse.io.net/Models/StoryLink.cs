using System;
using Newtonsoft.Json;

namespace Clubhouse.io.net.Models
{
    public class StoryLink
    {
        [JsonProperty(PropertyName = "created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty(PropertyName = "id")]
        public long ID { get; set; }

        [JsonProperty(PropertyName = "object_id")]
        public long ObjectID { get; set; }

        [JsonProperty(PropertyName = "subject_id")]
        public long SubjectID { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty(PropertyName = "verb")]
        public StoryVerbs Verb { get; set; }
    }
}