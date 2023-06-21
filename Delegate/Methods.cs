using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public  class Methods : MathMethod
    {
        public override void PrintInfo(string massege)
        {
            Console.WriteLine("FISH: " + massege);
        }

        public override int Sum(int number)
        {
            int summa = 0;
            for (int i = 1; i < number; i++)
            {
                summa += i;
            }

            return summa;
        }

        public override bool Tubmi(int number)
        {
            if (number < 2) return false;

            bool tubmi = true;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    tubmi = false;
                    break;
                }
            }

            if (tubmi)
            {
                return true;
            }
            return false;
        }
    }
}
