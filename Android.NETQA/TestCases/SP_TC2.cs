using Android.NETQA.Steps;
using NUnit.Framework;
using Serenity.TestCaseAbstraction;

namespace Android.NETQA.TestCases.StartPage
{
    [TestFixture]
    class SP_TC2:BaseTestCase
    {
        StartPageSteps UserAtStartPage { get; set; }
        ResultsOfSearchPageSteps UserAtResultsOfSearchPage { get; set; }

        [Test]
        public void TestSearchAppWithScrolling()
        {            
            UserAtStartPage.SearchVkApp();
            UserAtResultsOfSearchPage.ScrollDown();
            UserAtResultsOfSearchPage.GoBack();
        }       
    }
}
