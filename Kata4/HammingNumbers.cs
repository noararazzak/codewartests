using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics; 

namespace CodewarsTest
{
    class HammingNumbers
    {
        public BigInteger Hamming(int n)
        {
            int x = 0;
            int y = 0;
            int z = 0;
            BigInteger answer = 0;
            BigInteger twoh = 2;
            BigInteger threeh = 3;
            BigInteger fiveh = 5;
            BigInteger two = 2;
            BigInteger three = 3;
            BigInteger five = 5;
            var h = new BigInteger[n];
            h[0] = 1; 
            
           for (int index = 1; index < n; index = index + 1)
           {

              h[index] = BigInteger.Min(twoh, BigInteger.Min(threeh, fiveh)); 
              if (h[index] == twoh)
              {
                  x = x + 1;
                  twoh = two * h[x]; 
              }
              if (h[index] == threeh)
              {
                  y = y + 1;
                  threeh = three * h[y];
              }
              if (h[index] == fiveh)
              {
                  z = z + 1;
                  fiveh = five * h[z]; 
              }

                
            }
            return h[n - 1]; 
        }


    }
}
