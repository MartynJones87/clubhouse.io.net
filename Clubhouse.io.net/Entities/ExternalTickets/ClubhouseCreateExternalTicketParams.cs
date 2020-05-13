using Newtonsoft.Json;

namespace Clubhouse.io.net.Entities.ExternalTickets
{
    public class ClubhouseCreateExternalTicketParams
    {
        [JsonConstructor]
        public ClubhouseCreateExternalTicketParams(
            string externalID,
            string externalUrl
        )
        {
            ExternalID = externalID;
            ExternalUrl = externalUrl;
        }

        [JsonProperty(PropertyName = "external_id")]
        public string ExternalID { get; set; }

        [JsonProperty(PropertyName = "external_url")]
        public string ExternalUrl { get; set; }
    }
}
