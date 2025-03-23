using LeetCodeSharp.Interfaces;

namespace LeetCodeSharp.Problems
{
    // Given two strings s and t, return true if s is a subsequence of t, or false otherwise.
    // A subsequence of a string is a new string that is formed from the original string by deleting some(can be none)
    // of the characters without disturbing the relative positions of the remaining characters. (i.e., "ace" is a subsequence of "abcde" while "aec" is not).
    class P392_IsSubsequence : IProblem
    {
        public void Run()
        {
            var s = "abc";
            var t = "ahbgdc";
            var result = IsSubsequence(s, t);
        }

        public bool IsSubsequence(string s, string t)
        {
            int pS = 0;
            int pT = 0;

            while (pS < s.Length && pT < t.Length)
            {
                if (s[pS] == t[pT])
                {
                    pS++;
                    pT++;
                }
                else
                {
                    pT++;
                }
            }

            if (pS < s.Length)
            {
                return false;
            }

            return true;
        }
    }
}
