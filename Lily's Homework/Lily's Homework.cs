using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    /*
     * Complete the 'lilysHomework' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int lilysHomework(List<int> arr)
    {
        // Compute swaps for ascending and descending
        int asc = GetSwaps(new List<int>(arr), arr.OrderBy(x => x).ToList());
        int desc = GetSwaps(new List<int>(arr), arr.OrderByDescending(x => x).ToList());
        return Math.Min(asc, desc);
    }

    private static int GetSwaps(List<int> arr, List<int> sorted)
    {
        int n = arr.Count;
        Dictionary<int, int> indexMap = new Dictionary<int, int>();
        for (int i = 0; i < n; i++)
            indexMap[arr[i]] = i;

        int swaps = 0;

        for (int i = 0; i < n; i++)
        {
            if (arr[i] != sorted[i])
            {
                swaps++;

                int correctValue = sorted[i];
                int toSwapIndex = indexMap[correctValue];

                indexMap[arr[i]] = toSwapIndex;
                indexMap[correctValue] = i;

                int temp = arr[i];
                arr[i] = arr[toSwapIndex];
                arr[toSwapIndex] = temp;
            }
        }

        return swaps;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(x => Convert.ToInt32(x)).ToList();

        int result = Result.lilysHomework(arr);

        Console.WriteLine(result);
    }
}
