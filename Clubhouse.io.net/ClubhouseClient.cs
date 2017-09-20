using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using Clubhouse.io.net.Entities;
using Clubhouse.io.net.Entities.Categories;
using Clubhouse.io.net.Entities.Epics;
using Clubhouse.io.net.Entities.Files;
using Clubhouse.io.net.Entities.Labels;
using Clubhouse.io.net.Entities.LinkedFiles;
using Clubhouse.io.net.Entities.Members;
using Clubhouse.io.net.Entities.Milestones;
using Clubhouse.io.net.Entities.Projects;
using Clubhouse.io.net.Entities.Repositories;
using Clubhouse.io.net.Entities.Stories;
using Clubhouse.io.net.Entities.StoryLinks;
using Clubhouse.io.net.Entities.Teams;
using Clubhouse.io.net.Entities.Workflows;
using Refit;

namespace Clubhouse.io.net
{
    public class ClubhouseClient : IClubhouseClient
    {
        public static string ClubhouseAPIKey { get; set; }

        #region Categories

        public async Task<IEnumerable<ClubhouseCategory>> ListCategoriesAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<ClubhouseCategory> CreateCategoryAsync(ClubhouseCreateCategoryParams category)
        {
            throw new NotImplementedException();
        }

        public async Task<ClubhouseCategory> GetCategoryAsync(int categoryId)
        {
            throw new NotImplementedException();
        }

        public async Task<ClubhouseCategory> UpdateCategoryAsync(ClubhouseUpdateCategoryParams category, int categoryId)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteCategoryAsync(int categoryID)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ClubhouseEpic>> ListEpicsAsync(string token)
        {
            throw new NotImplementedException();
        }

        #endregion // Categories

        #region Epics

        public async Task<IEnumerable<ClubhouseEpic>> ListEpicsAsync()
        {
            var clubhouseApi = RestService.For<IClubhouseRestApi>("https://api.clubhouse.io/api");
            var clubhouseEpics = await clubhouseApi.ListEpicsAsync(ClubhouseAPIKey);

            return clubhouseEpics;
        }

        public async Task<ClubhouseEpic> CreateEpicAsync(ClubhouseCreateEpicParams epic, string token)
        {
            throw new NotImplementedException();
        }

        public async Task<ClubhouseEpic> GetEpicAsync(long epicId, string token)
        {
            throw new NotImplementedException();
        }

        public async Task<ClubhouseEpic> UpdateEpicAsync(ClubhouseUpdateEpicParams epicParams, long epicId, string token)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteEpicAsync(long epicID, string token)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ClubhouseThreadedComment>> ListEpicCommentsAsync(long epicId, string token)
        {
            throw new NotImplementedException();
        }

        public async Task<ClubhouseThreadedComment> CreateEpicCommentAsync(ClubhouseCreateEpicCommentParams commentParams, long epicId, string token)
        {
            throw new NotImplementedException();
        }

        public async Task<ClubhouseThreadedComment> GetEpicCommentAsync(long epicId, long commentId, string token)
        {
            throw new NotImplementedException();
        }

        public async Task<ClubhouseThreadedComment> CreateEpicCommentCommentAsync(ClubhouseCreateEpicCommentParams commentParams, long epicId, long commentId,
            string token)
        {
            throw new NotImplementedException();
        }

        public async Task<ClubhouseThreadedComment> UpdateEpicCommentAsync(ClubhouseUpdateEpicCommentParams commentParams, long epicId, long commentId, string token)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteEpicCommentAsync(long epicId, long commentId, string token)
        {
            throw new NotImplementedException();
        }

        #endregion // Epics

        #region Files

        public async Task<IEnumerable<ClubhouseFile>> ListFilesAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<ClubhouseFile> GetFileAsync(long fileId)
        {
            throw new NotImplementedException();
        }

        public async Task<ClubhouseFile> UpdateFileAsync(ClubhouseUpdateFileParams fileParams, long fileId)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteFileAsync(long fileId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ClubhouseFile>> UploadFilesAsync(IEnumerable<FileStream> files)
        {
            throw new NotImplementedException();
        }

        #endregion // Files

        #region Labels

        public async Task<IEnumerable<ClubhouseLabel>> ListLabelsAsync()
        {
            var clubhouseApi = RestService.For<IClubhouseRestApi>("https://api.clubhouse.io/api");
            var clubhouseLabels = await clubhouseApi.ListLabelsAsync(ClubhouseAPIKey);

            return clubhouseLabels;
        }

        public async Task<ClubhouseLabel> CreateLabelAsync(ClubhouseCreateLabelParams label)
        {
            throw new NotImplementedException();
        }

        public async Task<ClubhouseLabel> GetLabelAsync(int labelId)
        {
            throw new NotImplementedException();
        }

        public async Task<ClubhouseLabel> UpdateLabelAsync(ClubhouseUpdateLabelParams label, int labelId)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteLabelAsync(int labelID)
        {
            throw new NotImplementedException();
        }

        #endregion // Labels

        #region Linked Files

        public async Task<IEnumerable<ClubhouseLinkedFile>> ListLinkedFilesAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<ClubhouseLinkedFile> CreateLinkedFileAsync(ClubhouseCreateLinkedFileParams label)
        {
            throw new NotImplementedException();
        }

        public async Task<ClubhouseLinkedFile> GetLinkedFileAsync(long linkedFileId)
        {
            throw new NotImplementedException();
        }

        public async Task<ClubhouseLinkedFile> UpdateLinkedFileAsync(ClubhouseUpdateLinkedFileParams labelParams, long linkedFileId)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteLinkedFileAsync(long linkedFileId)
        {
            throw new NotImplementedException();
        }

        #endregion // Linked Files

        #region Members

        public async Task<IEnumerable<ClubhouseMember>> ListMembersAsync()
        {
            var clubhouseApi = RestService.For<IClubhouseRestApi>("https://api.clubhouse.io/api");
            var clubhouseMembers = await clubhouseApi.ListMembersAsync(ClubhouseAPIKey);

            return clubhouseMembers;
        }

        public async Task<ClubhouseMember> GetMemberAsync(long memberId)
        {
            throw new NotImplementedException();
        }

        #endregion // Members

        #region Milestones

        public async Task<IEnumerable<ClubhouseMilestone>> ListMilestonesAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<ClubhouseMilestone> CreateMilestoneAsync(ClubhouseCreateMilestoneParams milestone)
        {
            throw new NotImplementedException();
        }

        public async Task<ClubhouseMilestone> GetMilestoneAsync(int milestoneId)
        {
            throw new NotImplementedException();
        }

        public async Task<ClubhouseMilestone> UpdateMilestoneAsync(ClubhouseUpdateMilestoneParams milestone, int milestoneId)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteMilestoneAsync(int milestoneID)
        {
            throw new NotImplementedException();
        }

        #endregion // Milestones

        #region Projects

        public async Task<IEnumerable<ClubhouseProject>> ListProjectsAsync()
        {
            var clubhouseApi = RestService.For<IClubhouseRestApi>("https://api.clubhouse.io/api");
            var clubhouseProjects = await clubhouseApi.ListProjectsAsync(ClubhouseAPIKey);

            return clubhouseProjects;
        }

        public async Task<ClubhouseProject> CreateProjectAsync(ClubhouseCreateProjectParams project)
        {
            throw new NotImplementedException();
        }

        public async Task<ClubhouseProject> GetProjectAsync(long projectId)
        {
            throw new NotImplementedException();
        }

        public async Task<ClubhouseProject> UpdateProjectAsync(ClubhouseUpdateProjectParams projectParams, long projectId)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteProjectAsync(long projectId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ClubhouseStory>> ListStoriesAsync(long projectId)
        {
            throw new NotImplementedException();
        }

        #endregion // Projects

        #region Repositories

        public async Task<IEnumerable<ClubhouseRepository>> ListRepositoriesAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<ClubhouseRepository> GetRepositoryAsync(long repositoryId)
        {
            throw new NotImplementedException();
        }

        #endregion // Repositories

        #region Stories

        public async Task<ClubhouseStory> CreateStoryAsync(ClubhouseCreateStoryParams story)
        {
            try
            {
                var clubhouseApi = RestService.For<IClubhouseRestApi>("https://api.clubhouse.io/api");
                var clubhouseStory = await clubhouseApi.CreateStoryAsync(story, ClubhouseAPIKey);

                return clubhouseStory;
            }
            catch (Refit.ApiException apiException)
            {
                throw new ClubhouseApiException(apiException);
            }
        }

        public async Task<IEnumerable<ClubhouseStorySlim>> CreateMultipleStoriesAsync(List<ClubhouseCreateStoryParams> stories)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ClubhouseStorySlim>> UpdateMultipleStoriesAsync(ClubhouseUpdateMultipleStoryParams storiesParams)
        {
            throw new NotImplementedException();
        }

        public async Task<ClubhouseStory> GetStoryAsync(long storyID, ClubhouseStoryFields[] includeFields = null)
        {
            var clubhouseApi = RestService.For<IClubhouseRestApi>("https://api.clubhouse.io/api");
            var clubhouseStory = await clubhouseApi.GetStoryAsync(storyID, ClubhouseAPIKey);

            if (includeFields != null)
            {
                foreach (var field in includeFields)
                {
                    switch (field)
                    {
                        case ClubhouseStoryFields.Owners:
                        {
                            break;
                        }
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
            }

            return clubhouseStory;
        }

        public async Task<ClubhouseStory> UpdateStoryAsync(ClubhouseUpdateStoryParams storyParams, long storyId)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteStoryAsync(long storyId)
        {
            throw new NotImplementedException();
        }

        public async Task<ClubhouseComment> CreateCommentAsync(ClubhouseCreateCommentParams commentParams, long storyId)
        {
            throw new NotImplementedException();
        }

        public async Task<ClubhouseComment> GetCommentAsync(long storyId, long commentId)
        {
            throw new NotImplementedException();
        }

        public async Task<ClubhouseComment> UpdateCommentAsync(ClubhouseUpdateCommentParams commentParams, long storyId, long commentId)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteStoryAsync(long storyId, long commentId)
        {
            throw new NotImplementedException();
        }

        public async Task<ClubhouseTask> CreateTaskAsync(ClubhouseCreateTaskParams taskParams, long storyId)
        {
            throw new NotImplementedException();
        }

        public async Task<ClubhouseComment> GetTaskAsync(long storyId, long taskId)
        {
            throw new NotImplementedException();
        }

        public async Task<ClubhouseTask> UpdateTaskAsync(ClubhouseUpdateTaskParams taskParams, long storyId, long taskId)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteTaskAsync(long storyId, long taskId)
        {
            throw new NotImplementedException();
        }

        #endregion // Stories

        #region Story-Links

        public async Task<ClubhouseStoryLink> CreateStoryLinkAsync(ClubhouseCreateStoryLinkParams storyLinkParams, string token)
        {
            throw new NotImplementedException();
        }

        public async Task<ClubhouseStoryLink> GetStoryLink(long storyLinkId, string token)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteStoryLinkAsync(long storyLinkId, string token)
        {
            throw new NotImplementedException();
        }

        #endregion // Story-Links

        #region Teams

        public async Task<IEnumerable<ClubhouseTeam>> ListTeamsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<ClubhouseTeam> GetTeamAsync(long teamId, string token)
        {
            throw new NotImplementedException();
        }

        #endregion // Teams

        #region Workflows

        public async Task<IEnumerable<ClubhouseWorkflow>> ListWorkflowsAsync()
        {
            var clubhouseApi = RestService.For<IClubhouseRestApi>("https://api.clubhouse.io/api");
            var clubhouseWorkflows = await clubhouseApi.ListWorkflowsAsync(ClubhouseAPIKey);

            return clubhouseWorkflows;
        }

        #endregion // Workflows
    }
}
