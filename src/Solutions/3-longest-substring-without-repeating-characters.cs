using System.Collections.Generic;

namespace Solutions
{
    public partial class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            int length = 0;
            int startIndex = 0;
            var indexByChar = new Dictionary<char, int>();

            for (int endIndex = 0; endIndex < s.Length; endIndex++)
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
}
