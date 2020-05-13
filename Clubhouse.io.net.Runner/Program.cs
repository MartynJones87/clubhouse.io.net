using Clubhouse.io.net.Entities.Categories;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Clubhouse.io.net.Runner
{
    public class Program
    {
        private static Guid clubhouseOrganizationId;

        public static async Task Main(string[] args)
        {
            Console.WriteLine("Hello world!");

            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            var apiKey = config["apiKey"];
            clubhouseOrganizationId = Guid.Parse(config["clubhouseOrganizationId"]);

            var clubhouse = new ClubhouseClient(apiKey);

            await TestListMethodsAsync(clubhouse);
            await TestCategoryMethodsAsync(clubhouse);
        }

        private static async Task TestListMethodsAsync(IClubhouseClient clubhouse)
        {
            var categories = await clubhouse.ListCategoriesAsync();

            var epics = await clubhouse.ListEpicsAsync();
            var files = await clubhouse.ListFilesAsync();
            var labels = await clubhouse.ListLabelsAsync();
            var linkedFiles = await clubhouse.ListLinkedFilesAsync();
            var members = await clubhouse.ListMembersAsync(clubhouseOrganizationId);
            var milestones = await clubhouse.ListMilestonesAsync();
            var projects = await clubhouse.ListProjectsAsync();
            var repositories = clubhouse.ListRepositoriesAsync();
            var teams = clubhouse.ListTeamsAsync();
            var users = await clubhouse.ListMembersAsync(clubhouseOrganizationId);
            var workflows = await clubhouse.ListWorkflowsAsync();

            var projectId = projects.First().ID;
            var epicId = epics.First().ID;
            var stories = clubhouse.ListStoriesAsync(projectId);
            var epicComments = await clubhouse.ListEpicCommentsAsync(epicId);
        }

        private static async Task TestCategoryMethodsAsync(IClubhouseClient clubhouse)
        {
            var categoryParams = new ClubhouseCreateCategoryParams("Category Name", ClubhouseCategoryTypes.Milestone);

            var createdCategory = await clubhouse.CreateCategoryAsync(categoryParams);

            var getCategory = await clubhouse.GetCategoryAsync(createdCategory.ID);

            var updateCategoryParams = new ClubhouseUpdateCategoryParams();

            var updatedCategory = await clubhouse.UpdateCategoryAsync(updateCategoryParams, getCategory.ID);

            await clubhouse.DeleteCategoryAsync(updatedCategory.ID);
        }
    }
}
