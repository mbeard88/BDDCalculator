using System;
using TechTalk.SpecFlow;

namespace CalculatorBDDTests
{
    [Binding]
    public class CalculatorSteps
    {
        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I enter (.*) and (.*) into the calculator")]
        public void GivenIEnterAndIntoTheCalculator(int num1, int num1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"when I press add")]
        public void WhenWhenIPressAdd()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int expResult)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
