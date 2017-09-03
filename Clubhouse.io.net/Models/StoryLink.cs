using System;
using Clubhouse.io.net.RestAPI.Entities;

namespace Clubhouse.io.net.Models
{
    public class StoryLink
    {
        public DateTime? CreatedAt { get; set; }

        public string EntityType { get; set; }

        public long ID { get; set; }

        public long ObjectID { get; set; }

        public long SubjectID { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public ClubhouseStoryVerbs Verb { get; set; }
    }
}