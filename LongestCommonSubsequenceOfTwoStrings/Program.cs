using System;

namespace LongestCommonSubsequenceOfTwoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Longest Common Subsequence!");
            Console.WriteLine("----------------------------");

            Console.WriteLine("Enter the first string");
            string firstString = Console.ReadLine();
            Console.WriteLine("Enter the second string");
            string secondString = Console.ReadLine();

            int[,] lcs = new int[firstString.Length+1, secondString.Length+1];

            for (int i = 0; i <= firstString.Length; i++) {
                for (int j = 0; j <= secondString.Length; j++) {
                    if (i == 0 || j == 0) {
                        lcs[i, j] = 0;
                    }
                    else if (firstString[i - 1] == secondString[j - 1])
                    {
                        lcs[i, j] = 1 + lcs[i - 1, j - 1];
                    }
                    else {
                        lcs[i, j] = Math.Max(lcs[i-1, j], lcs[i, j-1]);
                    }
                }
            }

            Console.WriteLine("The length of common subsequence is "+lcs[firstString.Length, secondString.Length]);

            Console.ReadLine();
        }
    }
}
