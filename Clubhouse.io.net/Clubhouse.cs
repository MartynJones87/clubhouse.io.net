using System.Threading.Tasks;
using Clubhouse.io.net.Models;
using Clubhouse.io.net.RestAPI;
using Refit;

namespace Clubhouse.io.net
{
    public class Clubhouse : IClubhouse
    {
        public static string ClubhouseAPIKey { get; set; }

        public async Task<Story> GetStoryAsync(int storyID)
        {
            var clubhouseApi = RestService.For<IClubhouseRestApi>("https://api.clubhouse.io/api");
            var clubhouseStory = await clubhouseApi.GetStory(storyID, ClubhouseAPIKey);

            var story = new Story()
            {
                Name = clubhouseStory.Name
            };

            return story;
        }
    }
}
