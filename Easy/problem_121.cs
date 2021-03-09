/*
You are given an array prices where prices[i] is the price of a given stock on the ith day.

You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.
*/

public class Solution {
    public int MaxProfit(int[] prices) {
        int max_profit = 0;
        int curr_price = 0;
        int curr_profit = 0;
        
        for (int i = 0; i < prices.Length - 1; i++) {
            curr_price = prices[i];
            for (int j = i + 1; j < prices.Length; j++) {
                curr_profit = prices[j] - curr_price;
                if (curr_profit > max_profit) {
                    max_profit = curr_profit;
                }
            }   
        }
        
        if (max_profit > 0) {
            return max_profit;
        } else {
            return 0;
        }
    }
}