using CodeReviewPairs.Models;
using CodeReviewTools.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace CodeReviewPairs.Core
{
    public static class ReviewPairs
    {

 
        public static List<CodeReviewPairing> GetCodeReviewPairs(IEnumerable<string> participantCollection)
        {
            var participants = participantCollection.ToList();
            List<CodeReviewPairing> pairs = new List<CodeReviewPairing>();
            if (participants ==null || participants.Count < 2)
            {
                return new List<CodeReviewPairing>();
            }
            

            while (participants.Count > 1)
            {
                var reviewerIndex = Randomiser.GetRandomInt(0,participants.Count);

                var reviewer = participants[reviewerIndex];

                participants.RemoveAt(reviewerIndex);

                var revieweeIndex = Randomiser.GetRandomInt(0, participants.Count);

                var reviewee = participants[revieweeIndex];

                participants.RemoveAt(revieweeIndex);

                pairs.Add(new CodeReviewPairing(reviewer, reviewee));

            }
            //Odd number so pick a reviewee to be a reviewer
            if (participants.Any())
            {
                var reviewerIndex = Randomiser.GetRandomInt(0, pairs.Count);
                pairs.Add(new CodeReviewPairing(pairs[reviewerIndex].Reviewee, participants[0]));
            }
            return pairs;
        }
        
       

        

    }
}
