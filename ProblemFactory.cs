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

                ProblemCatalog.P28_FindIndexFirstOccurrenceString => new P28_FindIndexFirstOccurrenceString(),

                ProblemCatalog.P88_MergeSortedArray => new P88_MergeSortedArray(),

                _ => throw new NotImplementedException(),
            };
        }
    }
}
