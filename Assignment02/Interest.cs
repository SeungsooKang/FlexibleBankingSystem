using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    enum InterestMode
    {
        Simple,
        Compound
    }

    class Interest
    {
        public static double CalculateInterest(double balance, double rate, InterestMode mode)
        {
            double interest=0;

            switch (mode)
            {
                case InterestMode.Simple:
                    interest = balance * rate;
                    break;
                case InterestMode.Compound:
                    // I corrected Compound Interest Rate formula. It should deduct the original balance to only get interest.
                    interest = balance * (Math.Pow(1 + rate / 12, 12) - 1); 
                    break;
            }

            return interest;
        }
    }
}
