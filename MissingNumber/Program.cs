// Given an array nums containing n distinct numbers in the range [0, n], return the only number in the range that is missing from the array.

int[] nums1 = [3, 0, 1];
int missingNumber1 = Solution.MissingNumber(nums1);
Console.WriteLine(missingNumber1);

int[] nums2 = [0, 1];
int missingNumber2 = Solution.MissingNumber(nums2);
Console.WriteLine();
Console.WriteLine(missingNumber2);

int[] nums3 = [9, 6, 4, 2, 3, 5, 7, 0, 1];
int missingNumber3 = Solution.MissingNumber(nums3);
Console.WriteLine();
Console.WriteLine(missingNumber3);

public class Solution
{
	public static int MissingNumber(int[] nums)
	{
		int n = nums.Length;
		int expectedSum = n * (n + 1) / 2;
		int actualSum = 0;

		foreach (int num in nums)
		{
			actualSum += num;
		}

		return expectedSum - actualSum;
	}
}
