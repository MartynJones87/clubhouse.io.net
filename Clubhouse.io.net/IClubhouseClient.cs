using System.Collections.Generic;
using System.Threading.Tasks;
using Clubhouse.io.net.Entities;

namespace Clubhouse.io.net
{
    public interface IClubhouseClient
    {
        Task<ClubhouseStory> GetStoryAsync(int storyID);

        Task<ClubhouseStory> CreateStoryAsync(ClubhouseCreateStoryParams story);

        Task<IEnumerable<ClubhouseMember>> ListMembersAsync();

        Task<IEnumerable<ClubhouseProject>> ListProjectsAsync();

        Task<IEnumerable<ClubhouseEpic>> ListEpicsAsync();

        Task<IEnumerable<ClubhouseLabel>> ListLabelsAsync();
    }
}