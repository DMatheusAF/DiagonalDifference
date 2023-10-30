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
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        int first = 0, second = 0, i, size = arr.Count;

        for (i = 0; i < size; i++)
        {
            first += arr[i][i];
            second += arr[i][size - 1 - i];
        }

        return Math.Abs(first - second);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        List<List<int>> arr = new List<List<int>> {
            new List<int> { 11, 2, 4 },
            new List<int> { 4, 5, 6 },
            new List<int> { 10, 8, -12 }
        };

        int result = Result.diagonalDifference(arr);

        Console.WriteLine(result);
    }
}
