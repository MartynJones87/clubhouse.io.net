using Clubhouse.io.net.Entities.Stories;
using Newtonsoft.Json;

namespace Clubhouse.io.net.Entities.StoryLinks
{
    public class ClubhouseCreateStoryLinkParams
    {
        [JsonProperty(PropertyName = "object_id", Required = Required.Always)]
        public long ObjectID { get; set; }

        [JsonProperty(PropertyName = "subject_id", Required = Required.Always)]
        public long SubjectID { get; set; }

        [JsonProperty(PropertyName = "verb", Required = Required.Always)]
        public ClubhouseStoryVerbs Verb { get; set; }
    }
}