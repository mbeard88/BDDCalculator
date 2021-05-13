using BDDCalculator;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace CalculatorBDDTests
{

    [Binding]
    public class CalculatorSteps
    {
        private Calculator _calculator;
        private int _result;

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            _calculator = new Calculator();
        }
        
        [Given(@"I enter (.*) and (.*) into the calculator")]
        public void GivenIEnterAndIntoTheCalculator(int num1, int num2)
        {
            _calculator.Num1 = num1;
            _calculator.Num2 = num2;

        }
        
        [When(@"when I press add")]
        public void WhenWhenIPressAdd()
        {
            _result = _calculator.Add();
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int expResult)
        {
            Assert.That(_result, Is.EqualTo(expResult));
        }
    }
}
