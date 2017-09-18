using System.Collections.Generic;
using System.Threading.Tasks;
using Clubhouse.io.net.Entities;
using Refit;

namespace Clubhouse.io.net
{
    public class ClubhouseClient : IClubhouseClient
    {
        public static string ClubhouseAPIKey { get; set; }

        public async Task<ClubhouseStory> GetStoryAsync(int storyID)
        {
            var clubhouseApi = RestService.For<IClubhouseRestApi>("https://api.clubhouse.io/api");
            var clubhouseStory = await clubhouseApi.GetStory(storyID, ClubhouseAPIKey);

            return clubhouseStory;
        }

        public async Task<ClubhouseStory> CreateStoryAsync(ClubhouseCreateStoryParams story)
        {
            var clubhouseApi = RestService.For<IClubhouseRestApi>("https://api.clubhouse.io/api");
            var clubhouseStory = await clubhouseApi.CreateStory(story, ClubhouseAPIKey);

            return clubhouseStory;
        }

        public async Task<IEnumerable<ClubhouseMember>> ListMembersAsync()
        {
            var clubhouseApi = RestService.For<IClubhouseRestApi>("https://api.clubhouse.io/api");
            var clubhouseMembers = await clubhouseApi.ListMembers(ClubhouseAPIKey);

            return clubhouseMembers;
        }

        public async Task<IEnumerable<ClubhouseProject>> ListProjectsAsync()
        {
            var clubhouseApi = RestService.For<IClubhouseRestApi>("https://api.clubhouse.io/api");
            var clubhouseProjects = await clubhouseApi.ListProjects(ClubhouseAPIKey);

            return clubhouseProjects;
        }

        public async Task<IEnumerable<ClubhouseEpic>> ListEpicsAsync()
        {
            var clubhouseApi = RestService.For<IClubhouseRestApi>("https://api.clubhouse.io/api");
            var clubhouseEpics = await clubhouseApi.ListEpics(ClubhouseAPIKey);

            return clubhouseEpics;
        }

        public async Task<IEnumerable<ClubhouseLabel>> ListLabelsAsync()
        {
            var clubhouseApi = RestService.For<IClubhouseRestApi>("https://api.clubhouse.io/api");
            var clubhouseLabels = await clubhouseApi.ListLabels(ClubhouseAPIKey);

            return clubhouseLabels;
        }
    }
}
