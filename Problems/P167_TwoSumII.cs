using LeetCodeSharp.Interfaces;

namespace LeetCodeSharp.Problems
{
    class P167_TwoSumII : IProblem
    {
        public void Run()
        {
            var numbers = new int[] { 2, 7, 11, 15 };
            var target = 9;
            var result = TwoSum(numbers, target);
        }
        public int[] TwoSum(int[] numbers, int target)
        {

            var sumDict = new Dictionary<int, int>();

            var result = new int[2];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (sumDict.Count > 0 && sumDict.ContainsKey(numbers[i]))
                {
                    result[0] = sumDict[numbers[i]] + 1;
                    result[1] = i + 1;
                    break;
                }
                else
                {
                    sumDict[target - numbers[i]] = i;
                }
            }

            return result;
        }
    }
}
