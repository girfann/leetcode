namespace Solutions
{
    public partial class Solution
    {
        public string LongestPalindrome(string str)
        {
            if (string.IsNullOrEmpty(str) || str.Length == 1)
                return str;

            var longestPalindrome = string.Empty;

            for (int i = 0; i < str.Length - 1; i++)
            {
                var index = i;
                var currentStr = str[i].ToString();

                do
                {
                    index++;

                    if (IsPalindrome(currentStr) && currentStr.Length > longestPalindrome.Length)
                        longestPalindrome = currentStr;

                    if (index == str.Length)
                        break;

                    currentStr += str[index];
                }
                while (index < str.Length);
            }

            return longestPalindrome;
        }

        private bool IsPalindrome(string str)
        {
            if (str.Length == 1)
                return true;

            var left = 0;
            var right = str.Length - 1;

            while (left < right)
                if (str[left++] != str[right--])
                    return false;

            return true;
        }
    }
}
