using Newtonsoft.Json;

namespace Clubhouse.io.net.RestAPI.Entities
{
    public class ClubhouseCreateStoryLinkParams
    {
        [JsonProperty(PropertyName = "object_id")]
        public long ObjectID { get; set; }

        [JsonProperty(PropertyName = "subject_id")]
        public long SubjectID { get; set; }

        [JsonProperty(PropertyName = "verb")]
        public ClubhouseStoryVerbs Verb { get; set; }
    }
}