using LeetCodeSharp.Interfaces;

namespace LeetCodeSharp.Problems
{
    // You are given an integer array height of length n.There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and(i, height[i]).
    // Find two lines that together with the x-axis form a container, such that the container contains the most water.
    // Return the maximum amount of water a container can store.
    class P11_ContainerWithMostWater : IProblem
    {
        public void Run()
        {
            int[] heights = [1, 8, 6, 2, 5, 4, 8, 3, 7];
            var result = MaxArea(heights);
        }

        public static int MaxArea(int[] height)
        {
            // solução dos dois ponteiros

            int a = 0;
            int b = height.Length - 1;

            int maxArea = 0;

            while (a < b)
            {
                var currMaxArea = (b - a) * Math.Min(height[a], height[b]);

                maxArea = Math.Max(maxArea, currMaxArea);

                if (height[a] > height[b])
                {
                    b--;
                }
                else
                {
                    a++;
                }
            }

            return maxArea;
        }
    }
}
