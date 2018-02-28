using Android.NETQA.Steps;
using NUnit.Framework;
using Serenity.TestCaseAbstraction;

namespace Android.NETQA.TestCases.StartPage
{
    [TestFixture]
    class SP_TC1:BaseTestCase
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
