namespace Programming_Aptitude.Question3;

public static class Question3
{
    public static bool AreAnagrams(string? word1, string? word2)
    {
        /* Assumptions:
         - null and empty strings are *not* considered as anagrams
         - whitespaces (leading, trailing and within the words) are to be ignored
         - anagrams are case insensitive (eg. Word and word are anagrams)
         - input words can contain numbers (eg. 123 and 321 are anagrams)
         - input words can contain any UTF-16 character (eg. ϻϱǾ˅ and ˅Ǿϱϻ are anagrams)
        */
        if (word1 is null || word2 is null)
            return false;

        // space complexity: we're creating new strings, n + m
        word1 = word1.Replace(" ", string.Empty).ToLower();
        word2 = word2.Replace(" ", string.Empty).ToLower();
        
        if(word1 == string.Empty || word2 == string.Empty)
            return false;
        
        if (word1.Length != word2.Length)
            return false;

        // for both words, we figure out how many times each unique character appears
        // time complexity is n+m
        var word1LetterFrequency = GetFrequencyOfUniqueLetters(word1);
        var word2LetterFrequency = GetFrequencyOfUniqueLetters(word2);

        foreach (var characterFromWord1 in word1LetterFrequency.Keys)
        {
            if (!word2LetterFrequency.ContainsKey(characterFromWord1))
                return false;
            
            if (word1LetterFrequency[characterFromWord1] != word2LetterFrequency[characterFromWord1])
                return false;
        }

        return true;
    }
    
    private static Dictionary<char, int> GetFrequencyOfUniqueLetters(string word)
    {
        var frequency = new Dictionary<char, int>();
        
        foreach (var character in word)
        {
            if(!frequency.ContainsKey(character)) // seems faster than TryAdd()
                frequency.Add(character, 1);
            else
                frequency[character]++;
        }
        
        return frequency;
    }
}