using System;

namespace CodewarsTest
{
    class TribonacciSequence
    {
        public double[] Tribonacci(double[] signature, int n)
        {
            // hackonacci me
            // if n==0, then return an array of length 1, containing only a 0

            double[] answer = new double[n];

            if (n == 0)
            {
                return answer = new double[] { 0 };
            }

            else if (n == 1)
            {
                answer[0] = signature[0];
                return answer = new double[] { signature[0] };
            }

            else if (n == 2)
            {
                answer[0] = signature[0];
                answer[1] = signature[1];
                return answer = new double[] { signature[0], signature[1] };
            }

            else if (n == 3)
            {

                answer[0] = signature[0];
                answer[1] = signature[1];
                answer[2] = signature[2];
                return answer = new double[] { signature[0], signature[1], signature[2] };
            }

            else if (n == 4)
            {
                answer[0] = signature[0];
                answer[1] = signature[1];
                answer[2] = signature[2];
                answer[3] = signature[0] + signature[1] + signature[2];
                return answer = new double[] { signature[0], signature[1], signature[2], answer[3] };
            }

            else if (n == 5)
            {
                answer[0] = signature[0];
                answer[1] = signature[1];
                answer[2] = signature[2];
                answer[3] = signature[0] + signature[1] + signature[2];
                answer[4] = signature[1] + signature[2] + answer[3];
                return answer = new double[] { signature[0], signature[1], signature[2], answer[3], answer[4] };
            }

            else if (n == 6)
            {
                answer[0] = signature[0];
                answer[1] = signature[1];
                answer[2] = signature[2];
                answer[3] = signature[0] + signature[1] + signature[2];
                answer[4] = signature[1] + signature[2] + answer[3];
                answer[5] = +signature[2] + answer[3] + answer[4];
                return answer = new double[] { signature[0], signature[1], signature[2], answer[3], answer[4], answer[5] };
            }

            else if (n > 6)
            {
                answer[0] = signature[0];
                answer[1] = signature[1];
                answer[2] = signature[2];
                answer[3] = signature[0] + signature[1] + signature[2];
                answer[4] = signature[1] + signature[2] + answer[3];
                answer[5] = +signature[2] + answer[3] + answer[4];
                for (int i = 0; i < n - 6; i++)
                {
                    answer[6 + i] = answer[3 + i] + answer[4 + i] + answer[5 + i];
                }
                return answer;
            }

            return null;

        }
    }
}
