using Newtonsoft.Json;

namespace Clubhouse.io.net.Entities.Epics
{
    public class ClubhouseUpdateEpicCommentParams
    {
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }
    }
}