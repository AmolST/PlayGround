using System;
using TechTalk.SpecFlow;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorUnitTestProject
{
    [Binding]
    public class CalculatorSteps
    {
        private int result;
        private SimpleCalculator simpleCalculator =  new SimpleCalculator();

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            simpleCalculator.FirstNumber = number;
        }
        
        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int number)
        {
            simpleCalculator.SecondNumber = number;
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            result = simpleCalculator.Add();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(expectedResult, result);
        }
    }
}
