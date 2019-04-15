﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BDD1
{
    [Binding]

    class TestFeatureSteps
    {
        int[] numbers = new int[2];
        int counter = 0;
        int result = 0;


        [Given(@"I have entered '(.*)' into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            numbers[counter] = number;
            counter++;

        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            result = numbers.Sum();

        }

        [Then(@"the result should be '(.*)' on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.True(result == expectedResult, $"Sum of {numbers[0]} and {numbers[1]} should be equal");

        }
    }
}
