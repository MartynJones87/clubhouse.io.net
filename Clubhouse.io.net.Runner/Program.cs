using System;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using Clubhouse.io.net.Entities;

namespace Clubhouse.io.net.Runner
{
    public class Program
    {
        public static async System.Threading.Tasks.Task Main(string[] args)
        {
            Console.WriteLine("Hello world!");

            ClubhouseClient.ClubhouseAPIKey = ConfigurationManager.AppSettings["apiKey"];
            
            var clubhouse = new ClubhouseClient();
            //var story = await clubhouse.GetStoryAsync(7);

            //Debug.WriteLine(story.Name);

            var projects = await clubhouse.ListProjectsAsync();

            var newCreateStory = new ClubhouseCreateStoryParams()
            {
                Name = "Test Story Created Through The API",
                ProjectID = projects.FirstOrDefault()?.ID
            };

            var newStory = await clubhouse.CreateStoryAsync(newCreateStory);

            Debug.WriteLine(newStory.Name);

            //var members = await clubhouse.ListMembersAsync();

            //Debug.WriteLine(members);
        }
    }
}
