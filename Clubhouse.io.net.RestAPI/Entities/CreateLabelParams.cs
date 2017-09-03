using Newtonsoft.Json;

namespace Clubhouse.io.net.RestAPI.Entities
{
    public class CreateLabelParams
    {
        [JsonProperty(PropertyName = "external_id")]
        public long ExternalID { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Label { get; set; }
    }
}