using CodeReviewPairs.CoreLogic;
using System;
using System.Collections.Generic;
using Xunit;

namespace CodeReviewPairsTests
{
    public class RandomiserTests
    {
        [Fact]
        public void ShouldReturnARandomNumberBetween1and10()
        {
            for(int i =0; i<1000; i++)
            {
                var ans = Randomiser.GetRandomInt(1, 10);
                Assert.True(ans >= 1 && ans <= 10);
                Console.WriteLine(ans);
            }
        }

        [Fact]

        public void ShouldReturnEmptyCollectionForOneParticipant()
        {
            List<string> participants = new List<string> { "Dave", };
            var pairing = Randomiser.GetRandomisedPairings(participants);

            Assert.True(pairing.Count == 0);
        }

        [Fact]

        public void ShouldReturnEmptyCollectionForNoParticipant()
        {
            List<string> participants = new List<string>();
            var pairing = Randomiser.GetRandomisedPairings(participants);

            Assert.True(pairing.Count == 0);
        }


        [Fact]

        public void ShouldReturnCompletePairsEvenNumberOfParticipants()
        {
            List<string> participants = new List<string> { "Dave", "Fred", "Jenny", "Joe" };
            var pairing = Randomiser.GetRandomisedPairings(participants);

            Assert.True(pairing.Count == 2);
        }

        [Fact]
        public void ShouldReturnCompletePairsOddNumberOfParticipants()
        {
            List<string> participants = new List<string> { "Dave", "Fred", "Jenny", "Joe", "John" };
            var pairing = Randomiser.GetRandomisedPairings(participants);

            Assert.True(pairing.Count == 2);
        }
    }
}
