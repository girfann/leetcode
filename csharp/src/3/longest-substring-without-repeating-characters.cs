namespace LeetCode.src._3;

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        var length = 0;
        var startIndex = 0;
        var indexByChar = new Dictionary<char, int>();

        for (var endIndex = 0; endIndex < s.Length; endIndex++)
        {
            if (indexByChar.TryGetValue(s[endIndex], out var charLastIndex) && charLastIndex >= startIndex)
                startIndex = charLastIndex + 1;

            indexByChar[s[endIndex]] = endIndex;

            var windowLength = endIndex - startIndex + 1;

            if (windowLength > length)
                length = windowLength;
        }

        return length;
    }
}
