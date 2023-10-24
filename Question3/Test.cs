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
    
    [Theory]
    [InlineData("anagram", "nagaram")]
    [InlineData(" anagram", "nagaram")]
    [InlineData("a nagram", "nagaram")]
    [InlineData("1234567890", "0123456789")]
    [InlineData("WoRd", "wOrD")]
    [InlineData("ϻϱǾ\u02c5", "\u02c5Ǿϱϻ")]
    public void GivenTwoWordsWhichAreAnagrams_AreAnagrams_ReturnsTrue(string word1, string word2)
    {
        Question3.AreAnagrams(word1, word2).Should().BeTrue();
    }
    
    [Theory]
    [InlineData("car", "tar")]
    [InlineData("t", "tar")]
    [InlineData("tar", "32Ǿ")]
    public void GivenTwoWordsWhichAreNotAnagrams_AreAnagrams_ReturnsFalse(string word1, string word2)
    {
        Question3.AreAnagrams(word1, word2).Should().BeFalse();
    }
}