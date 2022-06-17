using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace GreatestCommonDivisor
{
    static class GCDAlgorithms
    {
        // Add FindGCDEuclid method
        public static int FindGCDEuclid(int a, int b)
        {
            int A = a, B = b;

            if (a == 0) return b;

            while (B > 0) 
            {
                if (A > B) A = A - B;
                else B = B - A;
            }

            return A; 
        }
    }
}
