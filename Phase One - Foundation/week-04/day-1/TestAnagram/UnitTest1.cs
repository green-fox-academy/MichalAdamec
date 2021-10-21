using System;
using Xunit;

namespace TestAnagram
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("makrela", "reklama")]
        //[InlineData("")]

        public void AllSetsAreAnagrams( string a, string b)
        {
            Assert.True(CompareTwoWords(a, b));
        }

        
    }
}
