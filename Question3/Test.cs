using FluentAssertions;
using Xunit;

namespace Programming_Aptitude.Question3;

public class Test
{
    [Fact]
    public void GivenTwoNulls_AreAnagrams_ReturnsFalse()
    {
        Question3.AreAnagrams(null, null).Should().BeFalse();
    }
    
    [Fact]
    public void GivenNullAndEmptyString_AreAnagrams_ReturnsFalse()
    {
        Question3.AreAnagrams(string.Empty, null).Should().BeFalse();
        Question3.AreAnagrams(null, string.Empty).Should().BeFalse();
    }
    
    [Fact]
    public void GivenTwoEmptyStrings_AreAnagrams_ReturnsFalse()
    {
        Question3.AreAnagrams(string.Empty, string.Empty).Should().BeFalse();
    }
    
    [Fact]
    public void GivenWhiteSpaces_AreAnagrams_ReturnsFalse()
    {
        Question3.AreAnagrams("   ", " ").Should().BeFalse();
    }
}