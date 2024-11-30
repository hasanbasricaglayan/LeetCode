// Given an array of integers nums which is sorted in ascending order, and an integer target, write a function to search target in nums.
// If target exists, then return its index. Otherwise, return -1.
// You must write an algorithm with O(log n) runtime complexity.

int[] nums1 = [-1, 0, 3, 5, 9, 12];
int target1 = 9;
int index1 = Solution.Search(nums1, target1);
Console.WriteLine(index1);

int[] nums2 = [-1, 0, 3, 5, 9, 12];
int target2 = 2;
int index2 = Solution.Search(nums2, target2);
Console.WriteLine();
Console.WriteLine(index2);

public class Solution
{
	public static int Search(int[] nums, int target)
	{
		int left = 0;
		int right = nums.Length - 1;

		while (left <= right)
		{
			int mid = left + ((right - left) / 2);

			if (nums[mid] == target)
			{
				return mid;
			}

			if (nums[mid] < target)
			{
				// Middle less than target, discard left half by making left search boundary 'mid + 1'
				left = mid + 1;
			}

			// if(nums[mid] > target)
			else
			{
				// Middle greater than target, discard right half by making right search boundary 'mid - 1'
				right = mid - 1;
			}
		}

		return -1;
	}
}
