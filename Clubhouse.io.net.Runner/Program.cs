using System;
using System.Configuration;
using Clubhouse.io.net.Models;
using Newtonsoft.Json;
using Refit;

namespace Clubhouse.io.net.Runner
{
    public class Program
    {
        public static async System.Threading.Tasks.Task Main(string[] args)
        {
            Console.WriteLine("Hello world!");

            var apiKey = ConfigurationManager.AppSettings["apiKey"];

            var clubhouseApi = RestService.For<IClubhouseApi>("https://api.clubhouse.io/api");
            var story = await clubhouseApi.GetStory(272, apiKey);

            Console.WriteLine(story.Name);

            var newStory = new CreateStoryParams()
            {
                Name = "Test Story Created Through The API",
                //ProjectID = 672
            };

            var newStoryCreated = await clubhouseApi.CreateStory(newStory, apiKey);

            Console.WriteLine(newStoryCreated.Name);
        }
    }
}
