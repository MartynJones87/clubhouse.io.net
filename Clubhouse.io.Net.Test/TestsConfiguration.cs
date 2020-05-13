using NUnit.Framework;

namespace Clubhouse.io.Net.Test
{
    [TestFixture]
    public class ClubhouseTestsBase
    {
        public static string ClubhouseApiKey { get; set; }
        public static string ClubhouseOrganizationId { get; set; }

        [OneTimeSetUp]
        public static void ConfigureTests()
        {
            ClubhouseApiKey = "59aa73f5-d1c5-4544-b6de-d6b56b7632bc";
            ClubhouseOrganizationId = "59aa73cf-2332-46f5-b757-54e0e6d021b4";
        }
    }
}
