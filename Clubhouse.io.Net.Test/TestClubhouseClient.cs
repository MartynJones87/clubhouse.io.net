using Clubhouse.io.net;
using NUnit.Framework;
using System;

namespace Clubhouse.io.Net.Test
{
    public class TestClubhouseClient : ClubhouseTestsBase
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestClubhouseClientCreationValidApiKey()
        {
            var clubhouse = new ClubhouseClient(ClubhouseApiKey);

            Assert.IsNotNull(clubhouse);
        }

        [Test]
        public void TestClubhouseClientCreationInvalidApiKey()
        {
            Assert.Throws<ArgumentException>(delegate { var clubhouse = new ClubhouseClient("blah-blah-blah"); });
        }
    }
}