using Newtonsoft.Json;

namespace Clubhouse.io.net.Entities.Labels
{
    public class ClubhouseCreateLabelParams
    {
        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }

        [JsonProperty(PropertyName = "external_id")]
        public string ExternalID { get; set; }

        [JsonProperty(PropertyName = "name", Required = Required.Always)]
        public string Name { get; set; }
    }
}
