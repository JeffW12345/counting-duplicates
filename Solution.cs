// Solution to exercise at https://www.codewars.com/kata/54bf1c2cd5b56cc47f0007a1

namespace CodeWarsChallenges
{
    using System;
    using System.Collections.Generic;

    class Solution
    {
        static int CountDuplicates(string word)
        {
            HashSet<String> listOfDuplicateLetters = new HashSet<String>();
            HashSet<String> toIgnoreList = new HashSet<String>();
            int duplicateCount = 0;
            foreach(char letter in word)
            {
                string charAsString = letter.ToString();
                string lowerCase = charAsString.ToLower();
                string upperCase = charAsString.ToUpper();
                if (toIgnoreList.Contains(lowerCase) || toIgnoreList.Contains(upperCase))
                {
                    continue;
                }
                if (listOfDuplicateLetters.Contains(lowerCase) || listOfDuplicateLetters.Contains(upperCase))
                {
                    duplicateCount++;
                    toIgnoreList.Add(lowerCase);
                    toIgnoreList.Add(upperCase);
                }
                listOfDuplicateLetters.Add(lowerCase);
                listOfDuplicateLetters.Add(upperCase);
            }
            return duplicateCount;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Number of duplicates: " + CountDuplicates("")); // Should be 0
            Console.WriteLine("Number of duplicates: " + CountDuplicates("aabbcde")); // Should be 2
            Console.WriteLine("Number of duplicates: " + CountDuplicates("aabBcde")); // Should be 2
            Console.WriteLine("Number of duplicates: " + CountDuplicates("indivisibility")); // Should be 1
            Console.WriteLine("Number of duplicates: " + CountDuplicates("Indivisibilities")); // Should be 2
            Console.WriteLine("Number of duplicates: " + CountDuplicates("aA11")); // Should be 2
            Console.WriteLine("Number of duplicates: " + CountDuplicates("ABBA")); // Should be 2
        }
    }
}
