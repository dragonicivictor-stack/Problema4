using Problema4;

namespace StringHelperTests
{
    public class StringHelperTest
    {
        [Theory]
        [InlineData("ana" , true)]
        [InlineData("masina", false)]
        [InlineData("cojoc", true)]

        public void IsPalindrom_WhenTextSoecified(string text, bool expected)
        {
            bool result = StringHelper.Ispalindrom(text);
            Assert.Equal(expected, result);
        }
    }
}