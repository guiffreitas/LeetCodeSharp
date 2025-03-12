using LeetCodeSharp.Interfaces;

namespace LeetCodeSharp.Problems
{
    // Given two strings needle and haystack, return the index of the first occurrence of needle in haystack,
    // or -1 if needle is not part of haystack.
    class P28_FindIndexFirstOccurrenceString : IProblem
    {
        public void Run()
        {
            var haystack = "hello";
            var needle = "ll";
            var result = StrStr(haystack, needle);
        }

        public int StrStr(string haystack, string needle)
        {

            if (needle.Length > haystack.Length)
            {
                return -1;
            }

            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                var hSubstr = haystack.Substring(i, needle.Length);

                if (hSubstr == needle)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
