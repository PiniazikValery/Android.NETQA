using Android.NETQA.Steps;
using Framework.TestCaseAbstraction;
using NUnit.Framework;

namespace Android.NETQA.TestCases.StartPage
{
    [TestFixture]
    class SP_TC2:TestCase
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
