﻿using CalcTests.UITests.Page;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CalcTests.UITests.UIAutomation
{
    [Binding]
    public class CalcAddingSteps
    {
        [When(@"I add (.*) and (.*)")]
        public void WhenIAddAnd(int p0, int p1)
        {
            var calcPage = ScenarioContext.Current.GetOrCreate<CalcPage>();
            calcPage.Add(p0, p1);
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(string p0)
        {
            var calcPage = ScenarioContext.Current.GetOrCreate<CalcPage>();
            Assert.AreEqual(p0, calcPage.GetResult());
        }

        [AfterScenario]
        public static void AfterFeature()
        {
            var calcPage = ScenarioContext.Current.GetOrCreate<CalcPage>();
            calcPage.Close();
        }
    }
}