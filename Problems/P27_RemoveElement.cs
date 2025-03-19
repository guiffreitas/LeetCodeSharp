using LeetCodeSharp.Interfaces;

namespace LeetCodeSharp.Problems
{
    class P27_RemoveElement : IProblem
    {
        public void Run()
        {
            var nums = new int[] { 3, 2, 2, 3 };
            var val = 3;
            var result = RemoveElement(nums, val);
        }

        public int RemoveElement(int[] nums, int val)
        {
            int n = nums.Length;
            int j = n;
            int k = 0;

            #region Edge case
            if (n == 0)
            {
                return 0;
            }
            #endregion

            for (int i = n - 1; i >= 0; i--)
            {
                if (nums[i] == val)
                {
                    k++;
                    while (j > i)
                    {
                        if (j < n && nums[j] != val)
                        {
                            nums[i] = nums[j];
                            nums[j] = val;
                            break;
                        }
                        else
                        {
                            j--;
                        }
                    }
                }
            }

            return n - k;
        }
    }
}
