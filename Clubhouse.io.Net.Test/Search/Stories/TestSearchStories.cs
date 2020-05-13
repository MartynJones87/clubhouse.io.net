using Clubhouse.io.net;
using Clubhouse.io.net.Entities.Search.Stories;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Clubhouse.io.Net.Test.Search.Stories
{
    public class TestSearchStories : ClubhouseTestsBase
    {
        private IClubhouseClient ClubhouseClient;

        [SetUp]
        public void Setup()
        {
            ClubhouseClient = new ClubhouseClient(ClubhouseApiKey);
        }

        [Test]
        public void TestSearchStoriesParametersEmptyQueryWithValidLimit()
        {
            Assert.Throws<ArgumentNullException>(delegate { var searchParams = new ClubhouseSearchStoriesParams(1, null); });
        }

        [Test]
        public void TestSearchStoriesParametersValidQueryWithInvalidLowLimit()
        {
            Assert.Throws<ArgumentOutOfRangeException>(delegate { var searchParams = new ClubhouseSearchStoriesParams(0, "query"); });
        }

        [Test]
        public void TestSearchStoriesParametersValidQueryWithInvalidHighLimit()
        {
            Assert.Throws<ArgumentOutOfRangeException>(delegate { var searchParams = new ClubhouseSearchStoriesParams(26, "query"); });
        }

        [Test]
        public async Task TestSearchStoriesParametersValidQueryValidLimitAsync()
        {
            var searchParams = new ClubhouseSearchStoriesParams(1, "Test");

            var searchResults = await ClubhouseClient.SearchStoriesAsync(searchParams);

            Assert.IsNotNull(searchResults);
            Assert.AreEqual(1, searchResults.Data.Count);
        }
    }
}
