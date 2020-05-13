using System;
using System.Collections.Generic;
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
using Clubhouse.io.net.Entities.Stories;
using Clubhouse.io.net.Entities.StoryLinks;
using Clubhouse.io.net.Entities.Teams;
using Clubhouse.io.net.Entities.Workflows;
using Refit;

namespace Clubhouse.io.net
{
    public interface IClubhouseRestApi
    {
        #region Categories

        [Obsolete]
        [Get("/v2/categories?token={token}")]
        Task<IEnumerable<ClubhouseCategory>> ListCategoriesAsync(string token);

        [Obsolete]
        [Post("/v2/categories?token={token}")]
        Task<ClubhouseCategory> CreateCategoryAsync([Body] ClubhouseCreateCategoryParams category, string token);

        [Obsolete]
        [Get("/v2/categories/{categoryId}?token={token}")]
        Task<ClubhouseCategory> GetCategoryAsync(long categoryId, string token);

        [Obsolete]
        [Put("/v2/categories/{categoryId}?token={token}")]
        Task<ClubhouseCategory> UpdateCategoryAsync([Body] ClubhouseUpdateCategoryParams categoryParams, long categoryId, string token);

        [Obsolete]
        [Delete("/v2/categories/{categoryId}?token={token}")]
        Task DeleteCategoryAsync(long categoryID, string token);

        #endregion // Categories

        #region Epics

        [Obsolete]
        [Get("/v2/epics?token={token}")]
        Task<IEnumerable<ClubhouseEpic>> ListEpicsAsync(string token);
        
        [Obsolete]
        [Post("/v2/epics?token={token}")]
        Task<ClubhouseEpic> CreateEpicAsync([Body] ClubhouseCreateEpicParams epic, string token);

        [Obsolete]
        [Get("/v2/epics/{epicId}?token={token}")]
        Task<ClubhouseEpic> GetEpicAsync(long epicId, string token);

        [Obsolete]
        [Put("/v2/epics/{epicId}?token={token}")]
        Task<ClubhouseEpic> UpdateEpicAsync([Body] ClubhouseUpdateEpicParams epicParams, long epicId, string token);

        [Obsolete]
        [Delete("/v2/epics/{epicId}?token={token}")]
        Task DeleteEpicAsync(long epicID, string token);
        
        [Obsolete]
        [Get("/v2/epics/{epicId}/comments?token={token}")]
        Task<IEnumerable<ClubhouseThreadedComment>> ListEpicCommentsAsync(long epicId, string token);

        [Obsolete]
        [Post("/v2/epics/{epicId}/comments?token={token}")]
        Task<ClubhouseThreadedComment> CreateEpicCommentAsync([Body] ClubhouseCreateEpicCommentParams commentParams, long epicId, string token);

        [Obsolete]
        [Get("/v2/epics/{epicId}/comments/{commentId}?token={token}")]
        Task<ClubhouseThreadedComment> GetEpicCommentAsync(long epicId, long commentId, string token);

        [Obsolete]
        [Post("/v2/epics/{epicId}/comments/{commentId}?token={token}")]
        Task<ClubhouseThreadedComment> CreateEpicCommentCommentAsync([Body] ClubhouseCreateEpicCommentParams commentParams, long epicId, long commentId, string token);

        [Obsolete]
        [Put("/v2/epics/{epicId}/comments/{commentId}?token={token}")]
        Task<ClubhouseThreadedComment> UpdateEpicCommentAsync([Body] ClubhouseUpdateEpicCommentParams commentParams, long epicId, long commentId, string token);

        [Obsolete]
        [Delete("/v2/epics/{epicId}/comments/{commentId}?token={token}")]
        Task DeleteEpicCommentAsync(long epicId, long commentId, string token);

        #endregion // Epics

        #region Files

        [Obsolete]
        [Get("/v2/files?token={token}")]
        Task<IEnumerable<ClubhouseFile>> ListFilesAsync(string token);

        [Obsolete]
        [Get("/v2/files/{fileId}?token={token}")]
        Task<ClubhouseFile> GetFileAsync(long fileId, string token);

        [Obsolete]
        [Put("/v2/files/{fileId}?token={token}")]
        Task<ClubhouseFile> UpdateFileAsync([Body] ClubhouseUpdateFileParams fileParams, long fileId, string token);

        [Obsolete]
        [Delete("/v2/files/{fileId}?token={token}")]
        Task DeleteFileAsync(long fileId, string token);

        [Obsolete]
        [Multipart]
        [Post("/v2/files?token={token}")]
        Task<IEnumerable<ClubhouseFile>> UploadFilesAsync(IEnumerable<StreamPart> files, string token);

        #endregion // Files

        #region Labels

        [Get("/v3/labels?token={token}")]
        Task<IEnumerable<ClubhouseLabel>> ListLabelsAsync(string token);

        [Post("/v3/labels?token={token}")]
        Task<ClubhouseLabel> CreateLabelAsync([Body] ClubhouseCreateLabelParams label, string token);

        [Obsolete]
        [Get("/v2/labels/{labelId}?token={token}")]
        Task<ClubhouseLabel> GetLabelAsync(long labelId, string token);

        [Obsolete]
        [Put("/v2/labels/{labelId}?token={token}")]
        Task<ClubhouseLabel> UpdateLabelAsync([Body] ClubhouseUpdateLabelParams labelParams, long labelId, string token);

        [Obsolete]
        [Delete("/v2/labels/{labelId}?token={token}")]
        Task DeleteLabelAsync(long labelId, string token);

        #endregion // Labels

        #region Linked Files

        [Obsolete]
        [Get("/v2/linked-files?token={token}")]
        Task<IEnumerable<ClubhouseLinkedFile>> ListLinkedFilesAsync(string token);

        [Obsolete]
        [Post("/v2/linked-files?token={token}")]
        Task<ClubhouseLinkedFile> CreateLinkedFileAsync([Body] ClubhouseCreateLinkedFileParams label, string token);

        [Obsolete]
        [Get("/v2/linked-files/{linkedFileId}?token={token}")]
        Task<ClubhouseLinkedFile> GetLinkedFileAsync(long linkedFileId, string token);

        [Obsolete]
        [Put("/v2/linked-files/{linkedFileId}?token={token}")]
        Task<ClubhouseLinkedFile> UpdateLinkedFileAsync([Body] ClubhouseUpdateLinkedFileParams labelParams, long linkedFileId, string token);

        [Obsolete]
        [Delete("/v2/linked-files/{linkedFileId}?token={token}")]
        Task DeleteLinkedFileAsync(long linkedFileId, string token);

        #endregion // Linked Files

        #region Members

        [Get("/v3/members?token={token}&org-public-id={orgPublicId}")]
        Task<IEnumerable<ClubhouseMember>> ListMembersAsync(Guid orgPublicId, string token);

        [Obsolete]
        [Get("/v2/members/{memberId}?token={token}")]
        Task<ClubhouseMember> GetMemberAsync(Guid memberId, string token);

        #endregion // Members

        #region Milestones

        [Obsolete]
        [Get("/v2/milestones?token={token}")]
        Task<IEnumerable<ClubhouseMilestone>> ListMilestonesAsync(string token);

        [Obsolete]
        [Post("/v2/milestones?token={token}")]
        Task<ClubhouseMilestone> CreateMilestoneAsync([Body] ClubhouseCreateMilestoneParams milestone, string token);

        [Obsolete]
        [Get("/v2/milestones/{milestoneId}?token={token}")]
        Task<ClubhouseMilestone> GetMilestoneAsync(long milestoneId, string token);

        [Obsolete]
        [Put("/v2/milestones/{milestoneId}?token={token}")]
        Task<ClubhouseMilestone> UpdateMilestoneAsync([Body] ClubhouseUpdateMilestoneParams milestoneParams, long milestoneId, string token);

        [Obsolete]
        [Delete("/v2/milestones/{milestoneId}?token={token}")]
        Task DeleteMilestoneAsync(long milestoneId, string token);

        #endregion // Milestones

        #region Projects

        [Obsolete]
        [Get("/v2/projects?token={token}")]
        Task<IEnumerable<ClubhouseProject>> ListProjectsAsync(string token);

        [Obsolete]
        [Post("/v2/projects?token={token}")]
        Task<ClubhouseProject> CreateProjectAsync([Body] ClubhouseCreateProjectParams project, string token);

        [Obsolete]
        [Get("/v2/projects/{projectId}?token={token}")]
        Task<ClubhouseProject> GetProjectAsync(long projectId, string token);

        [Obsolete]
        [Put("/v2/projects/{projectId}?token={token}")]
        Task<ClubhouseProject> UpdateProjectAsync([Body] ClubhouseUpdateProjectParams projectParams, long projectId, string token);

        [Obsolete]
        [Delete("/v2/projects/{projectId}?token={token}")]
        Task DeleteProjectAsync(long projectId, string token);

        [Obsolete]
        [Get("/v2/projects/{projectId}/stories?token={token}")]
        Task<IEnumerable<ClubhouseStory>> ListStoriesAsync(long projectId, string token);

        #endregion // Projects

        #region Repositories

        [Obsolete]
        [Get("/v2/repositories?token={token}")]
        Task<IEnumerable<ClubhouseRepository>> ListRepositoriesAsync(string token);

        [Obsolete]
        [Get("/v2/repositories/{repositoryId}?token={token}")]
        Task<ClubhouseRepository> GetRepositoryAsync(long repositoryId, string token);

        #endregion // Respositories

        #region Stories

        [Post("/v3/stories?token={token}")]
        Task<ClubhouseStory> CreateStoryAsync([Body] ClubhouseCreateStoryParams story, string token);

        [Obsolete]
        [Post("/v2/stories/bulk?token={token}")]
        Task<IEnumerable<ClubhouseStorySlim>> CreateMultipleStoriesAsync([Body] List<ClubhouseCreateStoryParams> stories, string token);

        [Obsolete]
        [Put("/v2/stories/bulk?token={token}")]
        Task<IEnumerable<ClubhouseStorySlim>> UpdateMultipleStoriesAsync([Body] ClubhouseUpdateMultipleStoryParams storiesParams, string token);

        [Obsolete]
        [Get("/v2/stories/{storyId}?token={token}")]
        Task<ClubhouseStory> GetStoryAsync(long storyId, string token);

        [Obsolete]
        [Put("/v2/stories/{storyId}/?token={token}")]
        Task<ClubhouseStory> UpdateStoryAsync([Body] ClubhouseUpdateStoryParams storyParams,
            long storyId, string token);

        [Obsolete]
        [Delete("/v2/stories/{storyId}?token={token}")]
        Task DeleteStoryAsync(long storyId, string token);

        [Obsolete]
        [Post("/v2/stories/{storyId}/comments?token={token}")]
        Task<ClubhouseComment> CreateCommentAsync([Body] ClubhouseCreateCommentParams commentParams, long storyId, string token);

        [Obsolete]
        [Get("/v2/stories/{storyId}/comments/{commentId}?token={token}")]
        Task<ClubhouseComment> GetCommentAsync(long storyId, long commentId, string token);

        [Obsolete]
        [Put("/v2/stories/{storyId}/comments/{commentId}?token={token}")]
        Task<ClubhouseComment> UpdateCommentAsync([Body] ClubhouseUpdateCommentParams commentParams, long storyId,
            long commentId, string token);

        [Obsolete]
        [Delete("/v2/stories/{storyId}/comments/{commentId}?token={token}")]
        Task DeleteStoryCommentAsync(long storyId, long commentId, string token);

        [Obsolete]
        [Post("/v2/stories/{storyId}/tasks?token={token}")]
        Task<ClubhouseTask> CreateTaskAsync([Body] ClubhouseCreateTaskParams taskParams, long storyId, string token);

        [Obsolete]
        [Get("/v2/stories/{storyId}/tasks/{taskId}?token={token}")]
        Task<ClubhouseComment> GetTaskAsync(long storyId, long taskId, string token);

        [Obsolete]
        [Put("/v2/stories/{storyId}/tasks/{taskId}?token={token}")]
        Task<ClubhouseTask> UpdateTaskAsync([Body] ClubhouseUpdateTaskParams taskParams, long storyId, long taskId, string token);

        [Obsolete]
        [Delete("/v2/stories/{storyId}/tasks/{taskId}?token={token}")]
        Task DeleteTaskAsync(long storyId, long taskId, string token);

        #endregion // Stories

        #region Story-Links

        [Obsolete]
        [Post("/v2/story-links?token={token}")]
        Task<ClubhouseStoryLink> CreateStoryLinkAsync([Body] ClubhouseCreateStoryLinkParams storyLinkParams,
            string token);

        [Obsolete]
        [Get("/v2/story-links/{storyLinkId}?token={token}")]
        Task<ClubhouseStoryLink> GetStoryLink(long storyLinkId, string token);

        [Obsolete]
        [Delete("/v2/story-links/{storyLinkId}?token={token}")]
        Task DeleteStoryLinkAsync(long storyLinkId, string token);

        #endregion // Story-Links

        #region Teams

        [Obsolete]
        [Get("/v2/teams?token={token}")]
        Task<IEnumerable<ClubhouseTeam>> ListTeamsAsync(string token);

        [Obsolete]
        [Get("/v2/teams/{teamId}?token={token}")]
        Task<ClubhouseTeam> GetTeamAsync(long teamId, string token);

        #endregion // Teams

        #region Workflows

        [Obsolete]
        [Get("/v2/workflows?token={token}")]
        Task<IEnumerable<ClubhouseWorkflow>> ListWorkflowsAsync(string token);

        #endregion // Workflows
    }
}