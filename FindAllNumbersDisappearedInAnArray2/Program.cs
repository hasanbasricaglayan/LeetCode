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
		HashSet<int> numsSet = new(nums);
		IList<int> missingNumbers = [];

		// Integers are in the range [1, n]
		for (int i = 1; i <= nums.Length; i++)
		{
			if (!numsSet.Contains(i))
			{
				missingNumbers.Add(i);
			}
		}

		return missingNumbers;
	}
}
