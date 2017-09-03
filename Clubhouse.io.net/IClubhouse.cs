using System.Threading.Tasks;
using Clubhouse.io.net.Models;

namespace Clubhouse.io.net
{
    public interface IClubhouse
    {
        Task<Story> GetStoryAsync(int storyID);
    }
}