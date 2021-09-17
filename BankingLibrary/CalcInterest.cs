using System;

namespace BankingLibrary
{
    public class CalcInterest:ICalcInterest
    {
        public int Calculate(int principle,int RateOfInterest, int years)
        {
            int SimpInt = (principle * RateOfInterest * years) / 100;
            return SimpInt;
        }
    }
}
