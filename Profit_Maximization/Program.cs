using System;
using System.IO;
using System.Linq;


public class Profit
{
    static public void Main()
    {
        var input = new int[] { 4, 7, 21, 26, 28, 29, 63, 34, 36, 126 };
        Console.WriteLine(solve(input));
    }

    static int solve(int[] p)
    {
        if (p == null || p.Length == 0) return 0;
        int maxProfit = 0;
        for (int i = p.Length - 1; i >= 0; i--)
        {
            int totalProfit = 0;
            int previousTraversablePrfit = 0;
            int currentProfit = 0;
            for (int j = i; j >= 0; j--)
            {
                currentProfit = p[j];
                if (j == i)
                {
                    totalProfit = p[j];
                    previousTraversablePrfit = p[j];
                }
                else if (previousTraversablePrfit % currentProfit == 0)
                {
                    totalProfit += currentProfit;
                    previousTraversablePrfit = currentProfit;
                }

            }
            maxProfit = maxProfit < totalProfit ? totalProfit : maxProfit;
        }
        return maxProfit;
    }

}
