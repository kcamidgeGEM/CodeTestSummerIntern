using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftwareTest
{
    /**
     * Welcome to the Coding Test. Please make sure you
     * read the instructions carefully.
     *
     * FAQ:
     * Can I use linq? Yes.
     * Can I cheat and look things up on Stack Overflow? Yes.
     * Fill in the TODO sections with code and comments
     */

    /// There are four challenges in this file

    public interface IChallenge
    {
        bool Success();
    }

    /// Lets find out
    public class Program
    {
        /// <summary>
        ///     Challenge #1 - NumberCalculator
        ///     Fill out the TODOs with your own code and make any
        ///     other appropriate improvements to this class.
        /// </summary>
        public class NumberCalculator : IChallenge
        {
            public int FindMax(int[] numbers)
            {
                //TODO: Find the highest number
                return 0;
            }

            public int[] FindMax(int[] numbers, int n)
            {
                // TODO: Find the 'n' highest numbers
                return Array.Empty<int>();
            }

            public int[] Sort(int[] numbers)
            {
                // TODO: Sort the numbers
                return Array.Empty<int>();
            }

            public bool Success()
            {
                var numbers = new[]
                {
                    5,
                    7,
                    5,
                    3,
                    6,
                    7,
                    9
                };
                var sorted = Sort(numbers);
                var maxes = FindMax(numbers, 2);

                // TODO: Are the following test cases sufficient, to prove your code works
                // as expected? If not either write more test cases and/or describe what
                // other tests cases would be needed.

                return sorted.FirstOrDefault() == 3
                    && sorted.LastOrDefault() == 9
                    && FindMax(numbers) == 9
                    && maxes[0] == 9
                    && maxes[1] == 7;
            }
        }

        /// <summary>
        ///     Challenge #2
        /// </summary>
        public class AreAnagrams : IChallenge
        {
            public bool AreStringsAnagrams(string a, string b)
            {
                //TODO: implement
                return false;
            }

            public bool Success()
            {
                //TODO: is this test case sufficient?
                return AreStringsAnagrams("momdad", "dadmom");
            }
        }

        /// <summary>
        ///     Challenge #3
        /// </summary>
        public class Palindrome : IChallenge
        {
            public bool IsPalindrome(string str)
            {
                //TODO: implement
                return false;
            }

            public bool Success()
            {
                //TODO: is this test case sufficient?
                return IsPalindrome("Noel sees Leon.");
            }
        }

        public static void Main(string[] args)
        {
            var challenges = new IChallenge[]
            {
                new NumberCalculator(),
                new AreAnagrams(),
                new Palindrome()
            };

            foreach (var challenge in challenges)
            {
                var challengeName = challenge.GetType().Name;

                var result = challenge.Success()
                    ? $"{challengeName} was successful"
                    : $"{challengeName} failed";

                Console.WriteLine(result);
            }

            Console.ReadLine();
        }
    }
}