using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeReviewPairs.Models
{
    public class CodeReviewPairing
    {
        public CodeReviewPairing( string reviewer, string reviewee )
        {

            Reviewer = reviewer;

            Reviewee = reviewee;

        }
        public string Reviewer { get; private set; }

        public string Reviewee { get; private set; }

        public bool IsPair { get { return string.IsNullOrEmpty(Reviewer) == false && string.IsNullOrEmpty(Reviewee); } }
    }
}
