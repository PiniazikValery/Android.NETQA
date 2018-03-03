using Android.NETQA.Steps;
using Framework.TestCaseAbstraction;
using NUnit.Framework;

namespace Android.NETQA.TestCases.StartPage
{
    [TestFixture]
    class SP_TC1:TestCase
    {
        StartPageSteps UserAtStartPage { get; set; }
        ResultsOfSearchPageSteps UserAtResultsOfSearchPage { get; set; }

        [Test]
        public void TestSearchApp()
        {            
            UserAtStartPage.SearchVkApp();
            UserAtResultsOfSearchPage.GoBack();
        }      
    }
}
