using CodeReviewPairs.Core;
using System;
using System.Collections.Generic;

namespace CodeReviewPairs.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> participants = new List<string> { "Rob", "Mel", "Owen", "Marcus", "Ben" };
            for (int i = 0; i < 10; i++)
            {
                var results = ReviewPairs.GetCodeReviewPairs(participants);

                foreach (var result in results)
                {
                    System.Console.WriteLine($"{result.Reviewer} will review {result.Reviewee}");
                }
            }
            System.Console.ReadKey();
        }
    }
}
