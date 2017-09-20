using Newtonsoft.Json;

namespace Clubhouse.io.net.Entities.Categories
{
    public class ClubhouseCreateCategoryParams
    {
        public ClubhouseCreateCategoryParams(string name, ClubhouseCategoryTypes type = ClubhouseCategoryTypes.Milestone)
        {
            Name = name;
            Type = type;
        }

        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }

        [JsonProperty(PropertyName = "external_id")]
        public string ExternalID { get; set; }

        [JsonProperty(PropertyName = "name", Required = Required.Always)]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        public ClubhouseCategoryTypes Type { get; set; }
    }
}
