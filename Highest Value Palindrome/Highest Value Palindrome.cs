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
     * Complete the 'highestValuePalindrome' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. INTEGER n
     *  3. INTEGER k
     */

    public static string highestValuePalindrome(string s, int n, int k)
    {
        char[] arr = s.ToCharArray();
        bool[] changed = new bool[n];
        int left = 0;
        int right = n - 1;

        // Step 1: Make the string a palindrome with minimal changes
        while (left < right)
        {
            if (arr[left] != arr[right])
            {
                char maxChar = (char)Math.Max(arr[left], arr[right]);
                arr[left] = arr[right] = maxChar;
                changed[left] = changed[right] = true;
                k--;
            }
            left++;
            right--;
        }

        // If not enough changes to make it palindrome
        if (k < 0)
            return "-1";

        // Step 2: Try to maximize the palindrome value
        left = 0;
        right = n - 1;

        while (left <= right)
        {
            if (left == right)
            {
                if (k > 0)
                    arr[left] = '9';
            }
            else
            {
                if (arr[left] != '9')
                {
                    if (changed[left] || changed[right])
                    {
                        if (k > 0)
                        {
                            arr[left] = arr[right] = '9';
                            k--;
                        }
                    }
                    else if (k > 1)
                    {
                        arr[left] = arr[right] = '9';
                        k -= 2;
                    }
                }
            }
            left++;
            right--;
        }

        return new string(arr);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        string s = Console.ReadLine();

        string result = Result.highestValuePalindrome(s, n, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
