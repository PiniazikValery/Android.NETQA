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
    class SP_TC1 : TestCase
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
