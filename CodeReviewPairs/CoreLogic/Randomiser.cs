using CodeReviewPairs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace CodeReviewPairs.CoreLogic
{
    public static class Randomiser
    {

       
        private static readonly RNGCryptoServiceProvider _rand = new RNGCryptoServiceProvider();


        public static List<CodeReviewPairing> GetRandomisedPairings(List<string> participants)
        {
            
            List<CodeReviewPairing> pairs = new List<CodeReviewPairing>();
            if (participants ==null || participants.Any() == false)
            {
                return new List<CodeReviewPairing>();
            }

            while (participants.Count > 1)
            {
                var reviewerIndex = GetRandomInt(0,participants.Count);

                var reviewer = participants[reviewerIndex];

                participants.RemoveAt(reviewerIndex);

                var revieweeIndex = GetRandomInt(0, participants.Count);

                var reviewee = participants[revieweeIndex];

                participants.RemoveAt(revieweeIndex);

                pairs.Add(new CodeReviewPairing(reviewer, reviewee));

            }
            
            return pairs;
        }

        public static int GetRandomInt(int min, int max)
        {                       
                // Get four random bytes.
                byte[] four_bytes = new byte[4];
                _rand.GetBytes(four_bytes);
                Random rnd = new Random(BitConverter.ToInt32(four_bytes, 0));
                return rnd.Next(min, max);
        }

    }
}
