using LeetCodeSharp.Interfaces;
using System.Diagnostics.Metrics;
using System.Text;

namespace LeetCodeSharp.Problems
{
    // A phrase is a palindrome if, after converting all uppercase letters into lowercase letters
    // and removing all non-alphanumeric characters, it reads the same forward and backward.Alphanumeric characters include letters and numbers.

    // Given a string s, return true if it is a palindrome, or false otherwise.
    class P125_ValidPalindrome : IProblem
    {
        public void Run()
        {
            string s = "A man, a plan, a canal: Panama";

            var result = IsPalindrome(s);
        }

        public bool IsPalindrome(string s)
        {
            //letters - ASCII 97 ~ 122
            //numbers - ASCII 48 ~ 57

            s = s.ToLower();

            var sb = new StringBuilder();

            foreach (var c in s.ToCharArray())
            {
                if (CharIsLetter(c) || CharIsNumber(c))
                {
                    sb.Append(c);
                }
            }

            var chars = sb.ToString();

            int a = 0;
            int b = chars.Length - 1;

            bool palindrome = true;

            while (a <= b)
            {
                if (chars[a] != chars[b])
                {
                    palindrome = false;
                    break;
                }
                a++;
                b--;
            }

            return palindrome;
        }

        private bool CharIsLetter(char c)
        {
            if ((int)c >= 97 && (int)c <= 122)
                return true;
            return false;
        }

        private bool CharIsNumber(char c)
        {
            if ((int)c >= 48 && (int)c <= 57)
                return true;
            return false;
        }
    }
}
