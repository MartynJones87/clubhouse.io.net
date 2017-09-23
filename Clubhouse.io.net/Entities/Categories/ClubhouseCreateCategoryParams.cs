using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Clubhouse.io.net.Entities.Categories
{
    public class ClubhouseCreateCategoryParams
    {
        public ClubhouseCreateCategoryParams(string name, ClubhouseCategoryTypes type = ClubhouseCategoryTypes.Milestone)
        {
            Name = name;
            Type = type;
        }

        [JsonProperty(PropertyName = "color", NullValueHandling = NullValueHandling.Ignore)]
        public string Color { get; set; }

        [JsonProperty(PropertyName = "external_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalID { get; set; }

        [JsonProperty(PropertyName = "name", Required = Required.Always)]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        [JsonConverter(typeof(StringEnumConverter))]
        public ClubhouseCategoryTypes Type { get; set; }
    }
}
