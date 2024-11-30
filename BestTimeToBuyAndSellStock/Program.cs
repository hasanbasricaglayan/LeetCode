// You are given an array prices where prices[i] is the price of a given stock on the ith day.
// You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
// Return the maximum profit you can achieve from this transaction.
// If you cannot achieve any profit, return 0.

int[] prices1 = [7, 1, 5, 3, 6, 4];
int maxProfit1 = Solution.MaxProfit(prices1);
Console.WriteLine(maxProfit1);

int[] prices2 = [7, 6, 4, 3, 1];
int maxProfit2 = Solution.MaxProfit(prices2);
Console.WriteLine();
Console.WriteLine(maxProfit2);

public class Solution
{
	public static int MaxProfit(int[] prices)
	{
		int minPrice = prices[0];
		int maxProfit = 0;

		for (int i = 1; i < prices.Length; i++)
		{
			if (prices[i] < minPrice)
			{
				minPrice = prices[i];

			}

			else
			{
				int profit = prices[i] - minPrice;
				if (profit > maxProfit)
				{
					maxProfit = profit;
				}
			}
		}

		return maxProfit;
	}
}
