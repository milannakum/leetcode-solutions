// Link: https://leetcode.com/problems/richest-customer-wealth/
// Name: 1672. Richest Customer Wealth

int MaximumWealth(int[][] accounts)
{
    int max = 0;
    for (int i = 0; i < accounts.Length; i++)
    {
        int tempMax = 0;
        for (int j = 0; j < accounts[i].Length; j++) tempMax += accounts[i][j];
        if (i == 0 || tempMax > max) max = tempMax;
    }
    return max;
}   
