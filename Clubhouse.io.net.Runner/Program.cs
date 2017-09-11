using System;
using System.Configuration;
using System.Diagnostics;
using Clubhouse.io.net.RestAPI.Entities;

namespace Clubhouse.io.net.Runner
{
    public class Program
    {
        public static async System.Threading.Tasks.Task Main(string[] args)
        {
            Console.WriteLine("Hello world!");

            Clubhouse.ClubhouseAPIKey = ConfigurationManager.AppSettings["apiKey"];
            
            var clubhouse = new Clubhouse();
            //var story = await clubhouse.GetStoryAsync(7);

            //Debug.WriteLine(story.Name);

            //var newCreateStory = new ClubhouseCreateStoryParams()
            //{
            //    Name = "Test Story Created Through The API",
            //    //ProjectID = 672
            //};

            //var newStory = await clubhouse.CreateStoryAsync(newCreateStory);

            //Debug.WriteLine(newStory.Name);

            var members = await clubhouse.ListMembersAsync();

            Debug.WriteLine(members);
        }
    }
}
