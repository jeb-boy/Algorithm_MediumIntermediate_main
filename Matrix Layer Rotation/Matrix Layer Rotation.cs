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
     * Complete the 'matrixRotation' function below.
     *
     * The function accepts following parameters:
     *  1. 2D_INTEGER_ARRAY matrix
     *  2. INTEGER r
     */

    public static void matrixRotation(List<List<int>> matrix, int r)
    {
        int m = matrix.Count;
        int n = matrix[0].Count;
        int layers = Math.Min(m, n) / 2;

        for (int layer = 0; layer < layers; layer++)
        {
            List<int> elements = new List<int>();

            // Top row
            for (int j = layer; j < n - layer; j++)
                elements.Add(matrix[layer][j]);

            // Right column
            for (int i = layer + 1; i < m - layer - 1; i++)
                elements.Add(matrix[i][n - layer - 1]);

            // Bottom row
            for (int j = n - layer - 1; j >= layer; j--)
                elements.Add(matrix[m - layer - 1][j]);

            // Left column
            for (int i = m - layer - 2; i > layer; i--)
                elements.Add(matrix[i][layer]);

            int len = elements.Count;
            int rotations = r % len;

            // Rotate
            List<int> rotated = new List<int>();
            rotated.AddRange(elements.Skip(rotations));
            rotated.AddRange(elements.Take(rotations));

            int idx = 0;

            // Fill top row
            for (int j = layer; j < n - layer; j++)
                matrix[layer][j] = rotated[idx++];

            // Fill right column
            for (int i = layer + 1; i < m - layer - 1; i++)
                matrix[i][n - layer - 1] = rotated[idx++];

            // Fill bottom row
            for (int j = n - layer - 1; j >= layer; j--)
                matrix[m - layer - 1][j] = rotated[idx++];

            // Fill left column
            for (int i = m - layer - 2; i > layer; i--)
                matrix[i][layer] = rotated[idx++];
        }

        // Print rotated matrix
        for (int i = 0; i < m; i++)
        {
            Console.WriteLine(string.Join(" ", matrix[i]));
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int m = Convert.ToInt32(firstMultipleInput[0]);

        int n = Convert.ToInt32(firstMultipleInput[1]);

        int r = Convert.ToInt32(firstMultipleInput[2]);

        List<List<int>> matrix = new List<List<int>>();

        for (int i = 0; i < m; i++)
        {
            matrix.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(matrixTemp => Convert.ToInt32(matrixTemp)).ToList());
        }

        Result.matrixRotation(matrix, r);
    }
}
