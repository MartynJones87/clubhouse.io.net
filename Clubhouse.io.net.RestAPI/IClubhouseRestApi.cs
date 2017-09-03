using System.Threading.Tasks;
using Clubhouse.io.net.RestAPI.Entities;
using Refit;

namespace Clubhouse.io.net.RestAPI
{
    public interface IClubhouseRestApi
    {
        //[Get("/v2/epics/{epic-public-id}?token={token}")]
        //Task<ClubhouseEpic> GetEpic([AliasAs("epic-public-id")] int epicId, string token);

        //[Put("/v2/epics/{epic-public-id}?token={token}")]
        //Task<ClubhouseEpic> UpdateEpic([Body] UpdateEpicParams epicParams, [AliasAs("epic-public-id")] int epicId, string token);

        //[Post("/v2/stories?token={token}")]
        //Task<ClubhouseStory> CreateStory([Body] ClubhouseCreateStoryParams storyParams, string token);

        [Get("/v2/stories/{story-public-id}?token={token}")]
        Task<ClubhouseStory> GetStory([AliasAs("story-public-id")] int storyId, string token);
    }
}