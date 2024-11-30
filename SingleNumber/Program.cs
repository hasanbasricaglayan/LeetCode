// Given a non-empty array of integers nums, every element appears twice except for one.
// Find that single one.
// You must implement a solution with a linear runtime complexity and use only constant extra space.

int[] nums1 = [2, 2, 1];
int singleNumber1 = Solution.SingleNumber(nums1);
Console.WriteLine(singleNumber1);

int[] nums2 = [4, 1, 2, 1, 2];
int singleNumber2 = Solution.SingleNumber(nums2);
Console.WriteLine();
Console.WriteLine(singleNumber2);

int[] nums3 = [1];
int singleNumber3 = Solution.SingleNumber(nums3);
Console.WriteLine();
Console.WriteLine(singleNumber3);

public class Solution
{
	public static int SingleNumber(int[] nums)
	{
		if (nums.Length == 1)
		{
			return nums[0];
		}

		// If we loop through the array and keep XORing the numbers together, the duplicates will cancel each other out and we are left with the single non-duplicate
		int singleNumber = nums[0];

		for (int i = 1; i < nums.Length; i++)
		{
			singleNumber = singleNumber ^ nums[i];
		}

		return singleNumber;
	}
}
