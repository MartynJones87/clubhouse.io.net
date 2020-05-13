using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Clubhouse.io.net.Entities.Categories;
using Clubhouse.io.net.Entities.Epics;
using Clubhouse.io.net.Entities.Files;
using Clubhouse.io.net.Entities.Labels;
using Clubhouse.io.net.Entities.LinkedFiles;
using Clubhouse.io.net.Entities.Members;
using Clubhouse.io.net.Entities.Milestones;
using Clubhouse.io.net.Entities.Projects;
using Clubhouse.io.net.Entities.Repositories;
using Clubhouse.io.net.Entities.Search.Stories;
using Clubhouse.io.net.Entities.Stories;
using Clubhouse.io.net.Entities.StoryLinks;
using Clubhouse.io.net.Entities.Teams;
using Clubhouse.io.net.Entities.Workflows;
using Refit;

namespace Clubhouse.io.net
{
    public class ClubhouseClient : IClubhouseClient
    {
        private string ClubhouseApiKey { get; }
        private IClubhouseRestApi ClubhouseApi { get; set; }

        /// <summary>
        /// Instantiates a new instance of the ClubhouseClient
        /// </summary>
        /// <param name="clubhouseApiKey"></param>
        public ClubhouseClient(string clubhouseApiKey)
        {
            var isApiKeyAValidGuid = Guid.TryParse(clubhouseApiKey, out var clubhouseApiKeyGuid);

            if (!isApiKeyAValidGuid)
            {
                throw new ArgumentException("Provided Clubhouse API Key is not a valid GUID value");
            }

            ClubhouseApiKey = clubhouseApiKey;
            ClubhouseApi = RestService.For<IClubhouseRestApi>("https://api.clubhouse.io/api");
        }

        #region Categories

        /// <summary>
        /// Gets all of  the <see cref="ClubhouseCategory"/>
        /// objects in the account
        /// </summary>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="ClubhouseCategory"/></returns>
        public async Task<IEnumerable<ClubhouseCategory>> ListCategoriesAsync()
        {
            var categories = await ClubhouseApi.ListCategoriesAsync(ClubhouseApiKey);

            return categories;
        }

        public async Task<ClubhouseCategory> CreateCategoryAsync(ClubhouseCreateCategoryParams categoryParams)
        {
            try
            {
                var category = await ClubhouseApi.CreateCategoryAsync(categoryParams, ClubhouseApiKey);

                return category;
            }
            catch (ApiException exception)
            {
                Debug.WriteLine(exception.Message);
                Debug.WriteLine(exception.Content);
                return null;
            }
        }

        public async Task<ClubhouseCategory> GetCategoryAsync(long categoryId)
        {
            try
            {
                var category = await ClubhouseApi.GetCategoryAsync(categoryId, ClubhouseApiKey);

                return category;
            }
            catch (ApiException exception)
            {
                Debug.WriteLine(exception.Message);
                Debug.WriteLine(exception.Content);
                return null;
            }
        }

        public async Task<ClubhouseCategory> UpdateCategoryAsync(ClubhouseUpdateCategoryParams categoryParams, long categoryId)
        {
            try
            {
                var category = await ClubhouseApi.UpdateCategoryAsync(categoryParams, categoryId, ClubhouseApiKey);

                return category;
            }
            catch (ApiException exception)
            {
                Debug.WriteLine(exception.Message);
                Debug.WriteLine(exception.Content);
                return null;
            }
        }

        public async Task DeleteCategoryAsync(long categoryID)
        {
            try
            {
                await ClubhouseApi.DeleteCategoryAsync(categoryID, ClubhouseApiKey);
            }
            catch (ApiException exception)
            {
                Debug.WriteLine(exception.Message);
                Debug.WriteLine(exception.Content);
            }
        }

        #endregion // Categories

        #region Epics

        /// <summary>
        /// Gets all of  the <see cref="ClubhouseEpic"/>
        /// objects in the account
        /// </summary>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="ClubhouseEpic"/></returns>
        public async Task<IEnumerable<ClubhouseEpic>> ListEpicsAsync()
        {
            var epics = await ClubhouseApi.ListEpicsAsync(ClubhouseApiKey);

            return epics;
        }

        public async Task<ClubhouseEpic> CreateEpicAsync(ClubhouseCreateEpicParams epic)
        {
            throw new NotImplementedException();
        }

        public async Task<ClubhouseEpic> GetEpicAsync(long epicId)
        {
            var epic = await ClubhouseApi.GetEpicAsync(epicId, ClubhouseApiKey);

            return epic;
        }

        public async Task<ClubhouseEpic> UpdateEpicAsync(ClubhouseUpdateEpicParams epicParams, long epicId)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteEpicAsync(long epicID)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets all of  the <see cref="ClubhouseThreadedComment"/> for the <see cref="ClubhouseEpic"/>
        /// with the given Epic ID.
        /// </summary>
        /// <param name="epicId">The ID of the <see cref="ClubhouseEpic"/> to get Threaded Comments for</param>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="ClubhouseThreadedComment"/></returns>
        public async Task<IEnumerable<ClubhouseThreadedComment>> ListEpicCommentsAsync(long epicId)
        {
            var epicComments = await ClubhouseApi.ListEpicCommentsAsync(epicId, ClubhouseApiKey);

            return epicComments;
        }

        public async Task<ClubhouseThreadedComment> CreateEpicCommentAsync(ClubhouseCreateEpicCommentParams commentParams, long epicId)
        {
            throw new NotImplementedException();
        }

        public async Task<ClubhouseThreadedComment> GetEpicCommentAsync(long epicId, long commentId)
        {
            throw new NotImplementedException();
        }

        public async Task<ClubhouseThreadedComment> CreateEpicCommentCommentAsync(ClubhouseCreateEpicCommentParams commentParams, long epicId, long commentId)
        {
            throw new NotImplementedException();
        }

        public async Task<ClubhouseThreadedComment> UpdateEpicCommentAsync(ClubhouseUpdateEpicCommentParams commentParams, long epicId, long commentId)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteEpicCommentAsync(long epicId, long commentId)
        {
            throw new NotImplementedException();
        }

        #endregion // Epics

        #region Files

        /// <summary>
        /// Gets all of  the <see cref="ClubhouseFile"/>
        /// objects in the account
        /// </summary>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="ClubhouseFile"/></returns>
        public async Task<IEnumerable<ClubhouseFile>> ListFilesAsync()
        {
            var files = await ClubhouseApi.ListFilesAsync(ClubhouseApiKey);

            return files;
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

        /// <summary>
        /// Gets all of  the <see cref="ClubhouseLabel"/>
        /// objects in the account
        /// </summary>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="ClubhouseLabel"/></returns>
        public async Task<IEnumerable<ClubhouseLabel>> ListLabelsAsync()
        {
            var clubhouseLabels = await ClubhouseApi.ListLabelsAsync(ClubhouseApiKey);

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

        /// <summary>
        /// Gets all of  the <see cref="ClubhouseLinkedFile"/>
        /// objects in the account
        /// </summary>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="ClubhouseLinkedFile"/></returns>
        public async Task<IEnumerable<ClubhouseLinkedFile>> ListLinkedFilesAsync()
        {
            var linkedFiles = await ClubhouseApi.ListLinkedFilesAsync(ClubhouseApiKey);

            return linkedFiles;
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

        /// <summary>
        /// Gets all of  the <see cref="ClubhouseMember"/>
        /// objects in the account.
        /// </summary>
        /// <param name="orgPublicId">The unique ID of the Organization to limit the list to.</param>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="ClubhouseMember"/></returns>
        public async Task<IEnumerable<ClubhouseMember>> ListMembersAsync(Guid orgPublicId)
        {
            var members = await ClubhouseApi.ListMembersAsync(orgPublicId, ClubhouseApiKey);

            return members;
        }

        public async Task<ClubhouseMember> GetMemberAsync(Guid memberId)
        {
            var member = await ClubhouseApi.GetMemberAsync(memberId, ClubhouseApiKey);

            return member;
        }

        public async Task<IEnumerable<ClubhouseMember>> GetMembersAsync(IEnumerable<Guid> memberIds)
        {
            var membersTasks = memberIds.Select(GetMemberAsync);
            var members = await Task.WhenAll(membersTasks);

            return members;
        }

        #endregion // Members

        #region Milestones

        /// <summary>
        /// Gets all of  the <see cref="ClubhouseMilestone"/>
        /// objects in the account
        /// </summary>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="ClubhouseMilestone"/></returns>
        public async Task<IEnumerable<ClubhouseMilestone>> ListMilestonesAsync()
        {
            var milestones = await ClubhouseApi.ListMilestonesAsync(ClubhouseApiKey);

            return milestones;
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

        /// <summary>
        /// Gets all of  the <see cref="ClubhouseProject"/>
        /// objects in the account
        /// </summary>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="ClubhouseProject"/></returns>
        public async Task<IEnumerable<ClubhouseProject>> ListProjectsAsync()
        {
            var clubhouseProjects = await ClubhouseApi.ListProjectsAsync(ClubhouseApiKey);

            return clubhouseProjects;
        }

        public async Task<ClubhouseProject> CreateProjectAsync(ClubhouseCreateProjectParams project)
        {
            throw new NotImplementedException();
        }

        public async Task<ClubhouseProject> GetProjectAsync(long projectId)
        {
            var project = await ClubhouseApi.GetProjectAsync(projectId, ClubhouseApiKey);

            return project;
        }

        public async Task<ClubhouseProject> UpdateProjectAsync(ClubhouseUpdateProjectParams projectParams, long projectId)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteProjectAsync(long projectId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets all of  the <see cref="ClubhouseStory"/>
        /// objects in the given <see cref="ClubhouseProject"/> ID.
        /// </summary>
        /// <param name="projectId">The ID of the <see cref="ClubhouseProject"/> to get the stories for</param>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="ClubhouseStory"/></returns>
        public async Task<IEnumerable<ClubhouseStory>> ListStoriesAsync(long projectId)
        {
            var stories = await ClubhouseApi.ListStoriesAsync(projectId, ClubhouseApiKey);

            return stories;
        }

        #endregion // Projects

        #region Repositories

        /// <summary>
        /// Gets all of  the <see cref="ClubhouseRepository"/>
        /// objects in the account
        /// </summary>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="ClubhouseRepository"/></returns>
        public async Task<IEnumerable<ClubhouseRepository>> ListRepositoriesAsync()
        {
            var repositories = await ClubhouseApi.ListRepositoriesAsync(ClubhouseApiKey);

            return repositories;
        }

        public async Task<ClubhouseRepository> GetRepositoryAsync(long repositoryId)
        {
            throw new NotImplementedException();
        }

        #endregion // Repositories

        #region Search

        public async Task<ClubhouseStorySearchResults> SearchStoriesAsync(ClubhouseSearchStoriesParams searchParams)
        {
            var results = await ClubhouseApi.SearchStoriesAsync(searchParams, ClubhouseApiKey);

            return results;
        }

        #endregion // Search

        #region Stories

        public async Task<ClubhouseStory> CreateStoryAsync(ClubhouseCreateStoryParams story)
        {
            try
            {
                var clubhouseStory = await ClubhouseApi.CreateStoryAsync(story, ClubhouseApiKey);

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
            var story = await ClubhouseApi.GetStoryAsync(storyID, ClubhouseApiKey);

            if (includeFields == null)
            {
                return story;
            }

            foreach (var field in includeFields)
            {
                switch (field)
                {
                    case ClubhouseStoryFields.Epic:
                        {
                            if (story.EpicID != null)
                            {
                                story.Epic = await GetEpicAsync((long)story.EpicID);
                            }
                            break;
                        }
                    case ClubhouseStoryFields.Followers:
                        {
                            story.Followers = await GetMembersAsync(story.FollowerIDs);
                            break;
                        }
                    case ClubhouseStoryFields.Owners:
                        {
                            story.Owners = await GetMembersAsync(story.OwnerIDs);
                            break;
                        }
                    case ClubhouseStoryFields.Project:
                        {
                            story.Project = await GetProjectAsync(story.ProjectID);
                            break;
                        }
                    case ClubhouseStoryFields.Requester:
                        {
                            story.Requester = await GetMemberAsync(story.RequestedByID);
                            break;
                        }
                    case ClubhouseStoryFields.WorkflowState:
                        {
                            var workflows = await ListWorkflowsAsync();
                            var states = workflows.SelectMany(w => w.States).ToList();
                            story.WorkflowState = states.FirstOrDefault(s => s.ID == story.WorkflowStateID);
                            break;
                        }
                    default:
                        {
                            throw new ArgumentOutOfRangeException();
                        }
                }
            }

            return story;
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

        public async Task<ClubhouseStoryLink> CreateStoryLinkAsync(ClubhouseCreateStoryLinkParams storyLinkParams)
        {
            throw new NotImplementedException();
        }

        public async Task<ClubhouseStoryLink> GetStoryLink(long storyLinkId)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteStoryLinkAsync(long storyLinkId)
        {
            throw new NotImplementedException();
        }

        #endregion // Story-Links

        #region Teams

        /// <summary>
        /// Gets all of  the <see cref="ClubhouseTeam"/>
        /// objects in the account
        /// </summary>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="ClubhouseTeam"/></returns>
        public async Task<IEnumerable<ClubhouseTeam>> ListTeamsAsync()
        {
            var teams = await ClubhouseApi.ListTeamsAsync(ClubhouseApiKey);

            return teams;
        }

        public async Task<ClubhouseTeam> GetTeamAsync(long teamId)
        {
            throw new NotImplementedException();
        }

        #endregion // Teams

        #region Workflows

        /// <summary>
        /// Gets all of  the <see cref="ClubhouseWorkflow"/>
        /// objects in the account
        /// </summary>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="ClubhouseWorkflow"/></returns>
        public async Task<IEnumerable<ClubhouseWorkflow>> ListWorkflowsAsync()
        {
            var clubhouseWorkflows = await ClubhouseApi.ListWorkflowsAsync(ClubhouseApiKey);

            return clubhouseWorkflows;
        }

        #endregion // Workflows
    }
}
