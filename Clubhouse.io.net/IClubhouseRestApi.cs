﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Clubhouse.io.net.Entities;
using Refit;

namespace Clubhouse.io.net
{
    public interface IClubhouseRestApi
    {
        //[Get("/v2/epics/{epic-public-id}?token={token}")]
        //Task<ClubhouseEpic> GetEpic([AliasAs("epic-public-id")] int epicId, string token);

        //[Put("/v2/epics/{epic-public-id}?token={token}")]
        //Task<ClubhouseEpic> UpdateEpic([Body] UpdateEpicParams epicParams, [AliasAs("epic-public-id")] int epicId, string token);

        //[Post("/v2/stories?token={token}")]
        //Task<ClubhouseStory> CreateStory([Body] ClubhouseCreateStoryParams storyParams, string token);

        [Get("/v2/stories/{story-public-id}?token={token}")]
        Task<ClubhouseStory> GetStory([AliasAs("story-public-id")] int storyId, string token);

        [Post("/v2/stories?token={token}")]
        Task<ClubhouseStory> CreateStory([Body] ClubhouseCreateStoryParams story, string token);

        [Get("/v2/members?token={token}")]
        Task<IEnumerable<ClubhouseMember>> ListMembers(string token);

        [Get("/v2/projects?token={token}")]
        Task<IEnumerable<ClubhouseProject>> ListProjects(string token);

        [Get("/v2/epics?token={token}")]
        Task<IEnumerable<ClubhouseEpic>> ListEpics(string token);

        [Get("/v2/labels?token={token}")]
        Task<IEnumerable<ClubhouseLabel>> ListLabels(string token);

        [Get("/v2/workflows?token={token}")]
        Task<IEnumerable<ClubhouseWorkflow>> ListWorkflows(string token);
    }
}