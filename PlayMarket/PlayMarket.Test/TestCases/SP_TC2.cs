using NUnit.Framework;
using PlayMarket.Test.Steps;
using PlayMarket.TestFramework.TestCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayMarket.Test.TestCases
{
    [TestFixture]
    class SP_TC2 : TestCase
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
