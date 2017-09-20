using Newtonsoft.Json;

namespace Clubhouse.io.net.Entities.Stories
{
    public class ClubhouseUpdateCommentParams
    {
        [JsonProperty(PropertyName = "text", Required = Required.Always)]
        public string Text { get; set; }
    }
}