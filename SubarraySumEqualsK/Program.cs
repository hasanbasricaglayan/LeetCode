// Given an array of integers nums and an integer k, return the total number of subarrays whose sum equals to k.
// A subarray is a contiguous non-empty sequence of elements within an array.

int[] nums1 = [1, 1, 1];
int k1 = 2;
int count1 = Solution.SubarraySum(nums1, k1);
Console.WriteLine(count1);

int[] nums2 = [1, 2, 3];
int k2 = 3;
int count2 = Solution.SubarraySum(nums2, k2);
Console.WriteLine();
Console.WriteLine(count2);

int[] nums3 = [1, 2, 3, 0, 3];
int k3 = 3;
int count3 = Solution.SubarraySum(nums3, k3);
Console.WriteLine();
Console.WriteLine(count3);

int[] nums4 = [4, 2, 9, 7, 19];
int k4 = 5;
int count4 = Solution.SubarraySum(nums4, k4);
Console.WriteLine();
Console.WriteLine(count4);

int[] nums5 = [-1, 1];
int k5 = 0;
int count5 = Solution.SubarraySum(nums5, k5);
Console.WriteLine();
Console.WriteLine(count5);

public class Solution
{
	public static int SubarraySum(int[] nums, int k)
	{
		int n = nums.Length;
		int count = 0;

		for (int i = 0; i < n; i++)
		{
			int sum = 0;

			for (int j = i; j < n; j++)
			{
				sum += nums[j];

				if (sum == k)
				{
					count++;
				}
			}
		}

		return count;
	}
}
