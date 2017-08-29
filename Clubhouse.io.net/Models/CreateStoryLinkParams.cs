using System;
using Newtonsoft.Json;

namespace Clubhouse.io.net.Models
{
    public class CreateStoryLinkParams
    {
        [JsonProperty(PropertyName = "object_id")]
        public long ObjectID { get; set; }

        [JsonProperty(PropertyName = "subject_id")]
        public long SubjectID { get; set; }

        [JsonProperty(PropertyName = "verb")]
        public StoryVerbs Verb { get; set; }
    }
}