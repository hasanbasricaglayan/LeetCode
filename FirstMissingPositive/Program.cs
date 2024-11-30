// Given an unsorted integer array nums. Return the smallest positive integer that is not present in nums.
// You must implement an algorithm that runs in O(n) time and uses O(1) auxiliary space.

int[] nums1 = [1, 2, 0];
int missingPositive1 = Solution.FirstMissingPositive(nums1);
Console.WriteLine(missingPositive1);

int[] nums2 = [3, 4, -1, 1];
int missingPositive2 = Solution.FirstMissingPositive(nums2);
Console.WriteLine();
Console.WriteLine(missingPositive2);

int[] nums3 = [7, 8, 9, 11, 12];
int missingPositive3 = Solution.FirstMissingPositive(nums3);
Console.WriteLine();
Console.WriteLine(missingPositive3);

public class Solution
{
	public static int FirstMissingPositive(int[] nums)
	{
		HashSet<int> numsSet = new(nums);

		for (int i = 1; i <= numsSet.Count; i++)
		{
			if (!numsSet.Contains(i))
			{
				return i;
			}
		}

		return numsSet.Count + 1;
	}
}
