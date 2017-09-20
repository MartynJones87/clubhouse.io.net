using System;
using System.Collections.Generic;
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

namespace Clubhouse.io.net
{
    public interface IClubhouseClient
    {
        #region Categories

        Task<IEnumerable<ClubhouseCategory>> ListCategoriesAsync();

        Task<ClubhouseCategory> CreateCategoryAsync(ClubhouseCreateCategoryParams category);

        Task<ClubhouseCategory> GetCategoryAsync(int categoryId);

        Task<ClubhouseCategory> UpdateCategoryAsync(ClubhouseUpdateCategoryParams category, int categoryId);

        Task DeleteCategoryAsync(int categoryID);

        #endregion // Categories

        #region Epics

        Task<IEnumerable<ClubhouseEpic>> ListEpicsAsync();

        Task<ClubhouseEpic> CreateEpicAsync(ClubhouseCreateEpicParams epic);

        Task<ClubhouseEpic> GetEpicAsync(long epicId);

        Task<ClubhouseEpic> UpdateEpicAsync(ClubhouseUpdateEpicParams epicParams, long epicId);

        Task DeleteEpicAsync(long epicID);

        Task<IEnumerable<ClubhouseThreadedComment>> ListEpicCommentsAsync(long epicId);

        Task<ClubhouseThreadedComment> CreateEpicCommentAsync(ClubhouseCreateEpicCommentParams commentParams, long epicId);

        Task<ClubhouseThreadedComment> GetEpicCommentAsync(long epicId, long commentId);

        Task<ClubhouseThreadedComment> CreateEpicCommentCommentAsync(ClubhouseCreateEpicCommentParams commentParams, long epicId, long commentId);

        Task<ClubhouseThreadedComment> UpdateEpicCommentAsync(ClubhouseUpdateEpicCommentParams commentParams, long epicId, long commentId);

        Task DeleteEpicCommentAsync(long epicId, long commentId);

        #endregion // Epics

        #region Files

        Task<IEnumerable<ClubhouseFile>> ListFilesAsync();

        Task<ClubhouseFile> GetFileAsync(long fileId);

        Task<ClubhouseFile> UpdateFileAsync(ClubhouseUpdateFileParams fileParams, long fileId);

        Task DeleteFileAsync(long fileId);

        Task<IEnumerable<ClubhouseFile>> UploadFilesAsync(IEnumerable<FileStream> files);

        #endregion // Files

        #region Labels

        Task<IEnumerable<ClubhouseLabel>> ListLabelsAsync();

        Task<ClubhouseLabel> CreateLabelAsync(ClubhouseCreateLabelParams label);

        Task<ClubhouseLabel> GetLabelAsync(int labelId);

        Task<ClubhouseLabel> UpdateLabelAsync(ClubhouseUpdateLabelParams label, int labelId);

        Task DeleteLabelAsync(int labelID);

        #endregion // Labels

        #region Linked Files

        Task<IEnumerable<ClubhouseLinkedFile>> ListLinkedFilesAsync();

        Task<ClubhouseLinkedFile> CreateLinkedFileAsync(ClubhouseCreateLinkedFileParams label);

        Task<ClubhouseLinkedFile> GetLinkedFileAsync(long linkedFileId);

        Task<ClubhouseLinkedFile> UpdateLinkedFileAsync(ClubhouseUpdateLinkedFileParams labelParams, long linkedFileId);

        Task DeleteLinkedFileAsync(long linkedFileId);

        #endregion // Linked Files

        #region Members

        Task<IEnumerable<ClubhouseMember>> ListMembersAsync();

        Task<ClubhouseMember> GetMemberAsync(Guid memberId);

        Task<IEnumerable<ClubhouseMember>> GetMembersAsync(IEnumerable<Guid> memberIds);

        #endregion // Members

        #region Milestones

        Task<IEnumerable<ClubhouseMilestone>> ListMilestonesAsync();

        Task<ClubhouseMilestone> CreateMilestoneAsync(ClubhouseCreateMilestoneParams milestone);

        Task<ClubhouseMilestone> GetMilestoneAsync(int milestoneId);

        Task<ClubhouseMilestone> UpdateMilestoneAsync(ClubhouseUpdateMilestoneParams milestone, int milestoneId);

        Task DeleteMilestoneAsync(int milestoneID);

        #endregion // Milestones

        #region Projects

        Task<IEnumerable<ClubhouseProject>> ListProjectsAsync();

        Task<ClubhouseProject> CreateProjectAsync(ClubhouseCreateProjectParams project);

        Task<ClubhouseProject> GetProjectAsync(long projectId);

        Task<ClubhouseProject> UpdateProjectAsync(ClubhouseUpdateProjectParams projectParams, long projectId);

        Task DeleteProjectAsync(long projectId);

        Task<IEnumerable<ClubhouseStory>> ListStoriesAsync(long projectId);

        #endregion // Projects

        #region Repositories

        Task<IEnumerable<ClubhouseRepository>> ListRepositoriesAsync();

        Task<ClubhouseRepository> GetRepositoryAsync(long repositoryId);

        #endregion // Repositories

        #region Stories

        Task<ClubhouseStory> CreateStoryAsync(ClubhouseCreateStoryParams story);

        Task<IEnumerable<ClubhouseStorySlim>> CreateMultipleStoriesAsync(List<ClubhouseCreateStoryParams> stories);

        Task<IEnumerable<ClubhouseStorySlim>> UpdateMultipleStoriesAsync(ClubhouseUpdateMultipleStoryParams storiesParams);

        Task<ClubhouseStory> GetStoryAsync(long storyID, ClubhouseStoryFields[] includeFields = null);

        Task<ClubhouseStory> UpdateStoryAsync(ClubhouseUpdateStoryParams storyParams, long storyId);

        Task DeleteStoryAsync(long storyId);

        Task<ClubhouseComment> CreateCommentAsync(ClubhouseCreateCommentParams commentParams, long storyId);

        Task<ClubhouseComment> GetCommentAsync(long storyId, long commentId);

        Task<ClubhouseComment> UpdateCommentAsync(ClubhouseUpdateCommentParams commentParams, long storyId,
            long commentId);

        Task DeleteStoryAsync(long storyId, long commentId);

        Task<ClubhouseTask> CreateTaskAsync(ClubhouseCreateTaskParams taskParams, long storyId);

        Task<ClubhouseComment> GetTaskAsync(long storyId, long taskId);

        Task<ClubhouseTask> UpdateTaskAsync(ClubhouseUpdateTaskParams taskParams, long storyId, long taskId);

        Task DeleteTaskAsync(long storyId, long taskId);

        #endregion // Stories

        #region Story-Links

        Task<ClubhouseStoryLink> CreateStoryLinkAsync(ClubhouseCreateStoryLinkParams storyLinkParams);

        Task<ClubhouseStoryLink> GetStoryLink(long storyLinkId);

        Task DeleteStoryLinkAsync(long storyLinkId);

        #endregion // Story-Links

        #region Teams

        Task<IEnumerable<ClubhouseTeam>> ListTeamsAsync();

        Task<ClubhouseTeam> GetTeamAsync(long teamId);

        #endregion // Teams

        #region Workflows

        Task<IEnumerable<ClubhouseWorkflow>> ListWorkflowsAsync();

        #endregion // Workflows
    }
}