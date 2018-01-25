using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CodeReviewTools.Core
{
   public static class Randomiser
    {
        private static readonly RNGCryptoServiceProvider _rand = new RNGCryptoServiceProvider();
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
