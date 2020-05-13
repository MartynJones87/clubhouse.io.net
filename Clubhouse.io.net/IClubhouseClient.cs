using System;
using System.Collections.Generic;
using System.IO;
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

namespace Clubhouse.io.net
{
    public interface IClubhouseClient
    {
        #region Categories

        [Obsolete]
        Task<IEnumerable<ClubhouseCategory>> ListCategoriesAsync();

        [Obsolete]
        Task<ClubhouseCategory> CreateCategoryAsync(ClubhouseCreateCategoryParams categoryParams);

        [Obsolete]
        Task<ClubhouseCategory> GetCategoryAsync(long categoryId);

        [Obsolete]
        Task<ClubhouseCategory> UpdateCategoryAsync(ClubhouseUpdateCategoryParams categoryParams, long categoryId);

        [Obsolete]
        Task DeleteCategoryAsync(long categoryID);

        #endregion // Categories

        #region Epics

        [Obsolete]
        Task<IEnumerable<ClubhouseEpic>> ListEpicsAsync();

        [Obsolete]
        Task<ClubhouseEpic> CreateEpicAsync(ClubhouseCreateEpicParams epic);

        [Obsolete]
        Task<ClubhouseEpic> GetEpicAsync(long epicId);

        [Obsolete]
        Task<ClubhouseEpic> UpdateEpicAsync(ClubhouseUpdateEpicParams epicParams, long epicId);

        [Obsolete]
        Task DeleteEpicAsync(long epicID);

        [Obsolete]
        Task<IEnumerable<ClubhouseThreadedComment>> ListEpicCommentsAsync(long epicId);

        [Obsolete]
        Task<ClubhouseThreadedComment> CreateEpicCommentAsync(ClubhouseCreateEpicCommentParams commentParams, long epicId);

        [Obsolete]
        Task<ClubhouseThreadedComment> GetEpicCommentAsync(long epicId, long commentId);

        [Obsolete]
        Task<ClubhouseThreadedComment> CreateEpicCommentCommentAsync(ClubhouseCreateEpicCommentParams commentParams, long epicId, long commentId);

        [Obsolete]
        Task<ClubhouseThreadedComment> UpdateEpicCommentAsync(ClubhouseUpdateEpicCommentParams commentParams, long epicId, long commentId);

        [Obsolete]
        Task DeleteEpicCommentAsync(long epicId, long commentId);

        #endregion // Epics

        #region Files

        [Obsolete]
        Task<IEnumerable<ClubhouseFile>> ListFilesAsync();

        [Obsolete]
        Task<ClubhouseFile> GetFileAsync(long fileId);

        [Obsolete]
        Task<ClubhouseFile> UpdateFileAsync(ClubhouseUpdateFileParams fileParams, long fileId);

        [Obsolete]
        Task DeleteFileAsync(long fileId);

        [Obsolete]
        Task<IEnumerable<ClubhouseFile>> UploadFilesAsync(IEnumerable<FileStream> files);

        #endregion // Files

        #region Labels

        Task<IEnumerable<ClubhouseLabel>> ListLabelsAsync();

        [Obsolete]
        Task<ClubhouseLabel> CreateLabelAsync(ClubhouseCreateLabelParams label);

        [Obsolete]
        Task<ClubhouseLabel> GetLabelAsync(int labelId);

        [Obsolete]
        Task<ClubhouseLabel> UpdateLabelAsync(ClubhouseUpdateLabelParams label, int labelId);

        [Obsolete]
        Task DeleteLabelAsync(int labelID);

        #endregion // Labels

        #region Linked Files

        [Obsolete]
        Task<IEnumerable<ClubhouseLinkedFile>> ListLinkedFilesAsync();

        [Obsolete]
        Task<ClubhouseLinkedFile> CreateLinkedFileAsync(ClubhouseCreateLinkedFileParams label);

        [Obsolete]
        Task<ClubhouseLinkedFile> GetLinkedFileAsync(long linkedFileId);

        [Obsolete]
        Task<ClubhouseLinkedFile> UpdateLinkedFileAsync(ClubhouseUpdateLinkedFileParams labelParams, long linkedFileId);

        [Obsolete]
        Task DeleteLinkedFileAsync(long linkedFileId);

        #endregion // Linked Files

        #region Members

        Task<IEnumerable<ClubhouseMember>> ListMembersAsync(Guid orgPublicId);

        [Obsolete]
        Task<ClubhouseMember> GetMemberAsync(Guid memberId);

        [Obsolete]
        Task<IEnumerable<ClubhouseMember>> GetMembersAsync(IEnumerable<Guid> memberIds);

        #endregion // Members

        #region Milestones

        [Obsolete]
        Task<IEnumerable<ClubhouseMilestone>> ListMilestonesAsync();

        [Obsolete]
        Task<ClubhouseMilestone> CreateMilestoneAsync(ClubhouseCreateMilestoneParams milestone);

        [Obsolete]
        Task<ClubhouseMilestone> GetMilestoneAsync(int milestoneId);

        [Obsolete]
        Task<ClubhouseMilestone> UpdateMilestoneAsync(ClubhouseUpdateMilestoneParams milestone, int milestoneId);

        [Obsolete]
        Task DeleteMilestoneAsync(int milestoneID);

        #endregion // Milestones

        #region Projects

        [Obsolete]
        Task<IEnumerable<ClubhouseProject>> ListProjectsAsync();

        [Obsolete]
        Task<ClubhouseProject> CreateProjectAsync(ClubhouseCreateProjectParams project);

        [Obsolete]
        Task<ClubhouseProject> GetProjectAsync(long projectId);

        [Obsolete]
        Task<ClubhouseProject> UpdateProjectAsync(ClubhouseUpdateProjectParams projectParams, long projectId);

        [Obsolete]
        Task DeleteProjectAsync(long projectId);

        [Obsolete]
        Task<IEnumerable<ClubhouseStory>> ListStoriesAsync(long projectId);

        #endregion // Projects

        #region Repositories

        [Obsolete]
        Task<IEnumerable<ClubhouseRepository>> ListRepositoriesAsync();

        [Obsolete]
        Task<ClubhouseRepository> GetRepositoryAsync(long repositoryId);

        #endregion // Repositories

        #region Stories

        Task<ClubhouseStory> CreateStoryAsync(ClubhouseCreateStoryParams story);

        [Obsolete]
        Task<IEnumerable<ClubhouseStorySlim>> CreateMultipleStoriesAsync(List<ClubhouseCreateStoryParams> stories);

        [Obsolete]
        Task<IEnumerable<ClubhouseStorySlim>> UpdateMultipleStoriesAsync(ClubhouseUpdateMultipleStoryParams storiesParams);

        [Obsolete]
        Task<ClubhouseStory> GetStoryAsync(long storyID, ClubhouseStoryFields[] includeFields = null);

        [Obsolete]
        Task<ClubhouseStory> UpdateStoryAsync(ClubhouseUpdateStoryParams storyParams, long storyId);

        [Obsolete]
        Task DeleteStoryAsync(long storyId);

        [Obsolete]
        Task<ClubhouseComment> CreateCommentAsync(ClubhouseCreateCommentParams commentParams, long storyId);

        [Obsolete]
        Task<ClubhouseComment> GetCommentAsync(long storyId, long commentId);

        [Obsolete]
        Task<ClubhouseComment> UpdateCommentAsync(ClubhouseUpdateCommentParams commentParams, long storyId,
            long commentId);

        [Obsolete]
        Task DeleteStoryAsync(long storyId, long commentId);

        [Obsolete]
        Task<ClubhouseTask> CreateTaskAsync(ClubhouseCreateTaskParams taskParams, long storyId);

        [Obsolete]
        Task<ClubhouseComment> GetTaskAsync(long storyId, long taskId);

        [Obsolete]
        Task<ClubhouseTask> UpdateTaskAsync(ClubhouseUpdateTaskParams taskParams, long storyId, long taskId);

        [Obsolete]
        Task DeleteTaskAsync(long storyId, long taskId);

        #endregion // Stories

        #region Story-Links

        [Obsolete]
        Task<ClubhouseStoryLink> CreateStoryLinkAsync(ClubhouseCreateStoryLinkParams storyLinkParams);

        [Obsolete]
        Task<ClubhouseStoryLink> GetStoryLink(long storyLinkId);

        [Obsolete]
        Task DeleteStoryLinkAsync(long storyLinkId);

        #endregion // Story-Links

        #region Teams

        [Obsolete]
        Task<IEnumerable<ClubhouseTeam>> ListTeamsAsync();

        [Obsolete]
        Task<ClubhouseTeam> GetTeamAsync(long teamId);

        #endregion // Teams

        #region Workflows

        [Obsolete]
        Task<IEnumerable<ClubhouseWorkflow>> ListWorkflowsAsync();

        #endregion // Workflows
    }
}