using System.Threading.Tasks;
using Clubhouse.io.net.Models;
using Refit;

namespace Clubhouse.io.net
{
    public interface IClubhouseApi
    {
        [Get("/v1/epics/{epic-public-id}?token={token}")]
        Task<Epic> GetEpic([AliasAs("epic-public-id")] int epicId, string token);

        [Put("/v1/epics/{epic-public-id}?token={token}")]
        Task<Epic> UpdateEpic([Body] UpdateEpicParams epicParams, [AliasAs("epic-public-id")] int epicId, string token);

        [Post("/v1/stories?token={token}")]
        Task<Story> CreateStory([Body] CreateStoryParams storyParams, string token);

        [Get("/v1/stories/{story-public-id}?token={token}")]
        Task<Story> GetStory([AliasAs("story-public-id")] int storyId, string token);
    }
}