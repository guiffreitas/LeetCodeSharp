using LeetCodeSharp.Interfaces;

namespace LeetCodeSharp.Problems
{
    // Given an integer array nums, return all the triplets[nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.
    // Notice that the solution set must not contain duplicate triplets.
    class P15_ThreeSum : IProblem
    {
        public void Run()
        {
            var nums = new int[] { -1, 0, 1, 2, -1, -4 };

            var result = ThreeSum(nums);
        }
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            // solution using two pointers, which skip over duplicate values
            // we fix one value inside the for-loop, and find the pairs that complete it
            // then we move to the next unique value and repeat the process

            Array.Sort(nums);

            var result = new List<IList<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                int target = -nums[i];
                int left = i + 1;
                int right = nums.Length - 1;

                while (left < right)
                {
                    if ((left > i + 1 && nums[left] == nums[left - 1])
                    || nums[left] + nums[right] < target)
                    {
                        left++;
                    }
                    else if ((right < nums.Length - 1 && nums[right] == nums[right + 1])
                    || nums[left] + nums[right] > target)
                    {
                        right--;
                    }
                    else
                    {
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });
                        left++;
                        right--;
                    }
                }
            }

            return result;
        }
        
    }
}
