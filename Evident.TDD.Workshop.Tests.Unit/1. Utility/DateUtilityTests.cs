using Evident.TDD.Workshop.Utility;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Evident.TDD.Workshop.Tests.Unit.Utility
{
    public class DateUtilityTests
    {
        //
        // EXAMPLE: This test checks if the utility method returns an empty string.
        //
        [Fact]
        public void ShouldReturnEmptyString()
        {
            var result = DateUtility.GetMonthDisplayValue(0);
            Assert.Equal(string.Empty, result);
        }

        // 
        // EXERCISE: Write a test to check the happy flow of the GetMonthDisplayValue method
        //



        //
        // QUESTION: What other tests should we write to cover all flows of the GetMonthDisplayValue method?
        //           You can use code coverage analysis to check how much of the method is actually covered.
        //

        //
        // QUESTION: Can you think of flows or edge cases that cause any problems or unhandeled exceptions?
        //

    }
}
