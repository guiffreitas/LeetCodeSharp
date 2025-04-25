using LeetCodeSharp.Interfaces;

namespace LeetCodeSharp.Problems
{
    // Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    class P1_TwoSum : IProblem
    {
        public void Run()
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            var result = TwoSum(nums, target);
        }

        public static int[] TwoSum(int[] nums, int target)
        {

            var map = new Dictionary<int, int>();
            
            var result = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                if (map.TryGetValue(nums[i], out int value))
                {
                    result = [value, i];
                    break;
                }
                else
                {
                    map[target - nums[i]] = i;
                }
            }

            return result;
        }
    }
}
