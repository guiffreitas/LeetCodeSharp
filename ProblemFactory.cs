using LeetCodeSharp.Enums;
using LeetCodeSharp.Interfaces;
using LeetCodeSharp.Problems;

namespace LeetCodeSharp
{
    class ProblemFactory
    {
        public static IProblem Create(ProblemCatalog problem)
        {
            return problem switch
            {
                ProblemCatalog.P1_TwoSum => new P1_TwoSum(),

                ProblemCatalog.P11_ContainerWithMostWater => new P11_ContainerWithMostWater(),

                ProblemCatalog.P27_RemoveElement => new P27_RemoveElement(),

                ProblemCatalog.P28_FindIndexFirstOccurrenceString => new P28_FindIndexFirstOccurrenceString(),

                ProblemCatalog.P68_TextJustification => new P68_TextJustification(),

                ProblemCatalog.P88_MergeSortedArray => new P88_MergeSortedArray(),

                ProblemCatalog.P125_ValidPalindrome => new P125_ValidPalindrome(),

                ProblemCatalog.P167_TwoSumII => new P167_TwoSumII(),

                ProblemCatalog.P392_IsSubsequence => new P392_IsSubsequence(),

                _ => throw new NotImplementedException(),
            };
        }
    }
}
