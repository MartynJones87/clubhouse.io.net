using System;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using Clubhouse.io.net.Entities;
using Clubhouse.io.net.Entities.Stories;

namespace Clubhouse.io.net.Runner
{
    public class Program
    {
        public static async System.Threading.Tasks.Task Main(string[] args)
        {
            Console.WriteLine("Hello world!");

            var apiKey = ConfigurationManager.AppSettings["apiKey"];
            
            var clubhouse = new ClubhouseClient(apiKey);
            //var story = await clubhouse.GetStoryAsync(7);

            //Debug.WriteLine(story.Name);

            var projects = await clubhouse.ListProjectsAsync();
            var workflows = await clubhouse.ListWorkflowsAsync();
            var users = await clubhouse.ListMembersAsync();

            //Debug.WriteLine(projects.FirstOrDefault()?.ID);

            var newCreateStory = new ClubhouseCreateStoryParams(
                "Test Story Created Through The API",
                projects.FirstOrDefault(), 
                users.FirstOrDefault(), 
                workflows.FirstOrDefault().States.First(), 
                ClubhouseStoryTypes.Feature);
            
            var newStory = await clubhouse.CreateStoryAsync(newCreateStory);

            //Debug.WriteLine(newStory.Name);

            //var members = await clubhouse.ListMembersAsync();

            //Debug.WriteLine(members);
        }
    }
}
