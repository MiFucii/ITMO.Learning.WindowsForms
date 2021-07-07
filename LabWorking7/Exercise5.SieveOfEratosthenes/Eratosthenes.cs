using System;

namespace Exercise5.SieveOfEratosthenes
{
    class Eratosthenes
    {
        public static string GoButt(int maxValue)
        {
            bool isPrime;
            string str="";
            for (int trial = 2; trial <= maxValue; trial++)
            {
                isPrime = true;
                for (int divisor = 2; divisor <= Math.Sqrt(trial); divisor++)
                {
                    if (trial % divisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    if (trial == 2) str = string.Concat(str, "  ", trial);
                    else
                    {
                        switch (trial.ToString().Length)
                        {
                            case 1: str = string.Concat(str, "   ", trial); break;
                            case 2: str = string.Concat(str, "  ", trial); break;
                            case 3: str = string.Concat(str, " ", trial); break;
                        }
                    }
                }
            }
            return str;
        }
    }
}
