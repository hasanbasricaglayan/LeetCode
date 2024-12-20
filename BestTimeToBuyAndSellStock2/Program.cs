// You are given an integer array prices where prices[i] is the price of a given stock on the ith day.
// On each day, you may decide to buy and/or sell the stock.
// You can only hold at most one share of the stock at any time.
// However, you can buy it then immediately sell it on the same day.
// Find and return the maximum profit you can achieve.

int[] prices1 = [7, 1, 5, 3, 6, 4];
int totalMaxProfit1 = Solution.MaxProfit(prices1);
Console.WriteLine(totalMaxProfit1);

int[] prices2 = [1, 2, 3, 4, 5];
int totalMaxProfit2 = Solution.MaxProfit(prices2);
Console.WriteLine();
Console.WriteLine(totalMaxProfit2);

int[] prices3 = [7, 6, 4, 3, 1];
int totalMaxProfit3 = Solution.MaxProfit(prices3);
Console.WriteLine();
Console.WriteLine(totalMaxProfit3);

public class Solution
{
	public static int MaxProfit(int[] prices)
	{
		int totalMaxProfit = 0;

		for (int i = 0; i < prices.Length - 1; i++)
		{
			if (prices[i] < prices[i + 1])
			{
				totalMaxProfit += prices[i + 1] - prices[i];
			}
		}

		return totalMaxProfit;
	}
}
