using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clubhouse.io.net.Entities.Search.Stories
{
    public class ClubhouseSearchStoriesParams
    {
        /// <summary>
        /// The body parameters to be passed to the SearchStories API endpoint
        /// </summary>
        /// <param name="pageSize">An integer value between 1 and 25.</param>
        /// <param name="query">A non-null term to search for stories containing.</param>
        [JsonConstructor]
        public ClubhouseSearchStoriesParams(long pageSize, string query)
        {
            if(query == null)
            {
                throw new ArgumentNullException(nameof(query));
            }

            if(pageSize < 1 || pageSize > 25)
            {
                throw new ArgumentOutOfRangeException(nameof(pageSize), "pageSize must be between 1 and 25");
            }
            
            PageSize = pageSize;
            Query = query;

            InitialiseRequiredFields();
        }

        private void InitialiseRequiredFields()
        {
        }

        [JsonProperty(PropertyName = "page_size", NullValueHandling = NullValueHandling.Ignore)]
        public long? PageSize { get; set; }

        [JsonProperty(PropertyName = "query", Required = Required.Always)]
        public string Query { get; set; }
    }
}
