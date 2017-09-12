using Newtonsoft.Json;

namespace Clubhouse.io.net.RestAPI.Entities
{
    public class CreateLabelParams
    {

        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }

        [JsonProperty(PropertyName = "external_id")]
        public string ExternalID { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Label { get; set; }
    }
}