// Given an array nums containing n distinct numbers in the range [1, n], return the only number in the range that is missing from the array.

int[] nums1 = [1, 3, 5, 4];
int missingNumber1 = Solution.MissingNumber(nums1);
Console.WriteLine(missingNumber1);

int[] nums2 = [6, 3, 4, 5, 2];
int missingNumber2 = Solution.MissingNumber(nums2);
Console.WriteLine();
Console.WriteLine(missingNumber2);

int[] nums3 = [5, 3, 2, 1, 4];
int missingNumber3 = Solution.MissingNumber(nums3);
Console.WriteLine();
Console.WriteLine(missingNumber3);

public class Solution
{
	public static int MissingNumber(int[] nums)
	{
		int n = nums.Length + 1;
		int expectedSum = n * (n + 1) / 2;
		int actualSum = 0;

		foreach (int num in nums)
		{
			actualSum += num;
		}

		return expectedSum - actualSum;
	}
}
