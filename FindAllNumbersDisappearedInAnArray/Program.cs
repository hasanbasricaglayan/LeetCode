// Given an array nums of n integers where nums[i] is in the range [1, n], return an array of all the integers in the range [1, n] that do not appear in nums.

int[] nums1 = [4, 3, 2, 7, 8, 2, 3, 1];
IList<int> disappearedNumbers1 = Solution.FindDisappearedNumbers(nums1);
foreach (int num in disappearedNumbers1)
{
	Console.WriteLine(num);
}

int[] nums2 = [1, 1];
IList<int> disappearedNumbers2 = Solution.FindDisappearedNumbers(nums2);
Console.WriteLine();
foreach (int num in disappearedNumbers2)
{
	Console.WriteLine(num);
}

public class Solution
{
	public static IList<int> FindDisappearedNumbers(int[] nums)
	{
		// Iterate over each number in the array
		for (int i = 0; i < nums.Length; i++)
		{
			// Use absolute value in case nums[i] has been marked negative already
			int index = Math.Abs(nums[i]) - 1;

			// Mark the number at index 'index' as negative if it's not already
			if (nums[index] > 0)
			{
				nums[index] = -nums[index];
			}
		}

		// Create a list to hold the result of missing numbers
		IList<int> missingNumbers = [];

		// Check for numbers that were not marked negative
		for (int i = 0; i < nums.Length; i++)
		{
			// If the number is positive, the number (i + 1) is missing
			if (nums[i] > 0)
			{
				missingNumbers.Add(i + 1);
			}
		}

		return missingNumbers;
	}
}

//abs(4) - 1 = 3
//nums[3] = 7 > 0 => nums[3] = -7

//abs(3) - 1 = 2
//nums[2] = 2 > 0 => nums[2] = -2

//abs(-2) - 1 = 1
//nums[1] = 3 > 0 => nums[1] = -3

//abs(-7) - 1 = 6
//nums[6] = 3 > 0 => nums[6] = -3

//abs(8) - 1 = 7
//nums[7] = 1 > 0 => nums[7] = -1

//abs(2) - 1 = 1
//nums[1] = -3 < 0

//abs(-3) - 1 = 2
//nums[2] = -2 < 0

//abs(-1) - 1 = 0
//nums[0] = 4 > 0 => nums[0] = -4
