using LeetCodeSharp.Enums;
using LeetCodeSharp.Interfaces;
using LeetCodeSharp.Problems;

namespace LeetCodeSharp
{
    class ProblemFactory
    {
        public static IProblem Create(ProblemCatalog problem)
        {
            switch (problem)
            {
                case ProblemCatalog.P88_MergeSortedArray:
                    return new P88_MergeSortedArray();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
