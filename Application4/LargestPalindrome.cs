using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application4
{
    public class MainFuncation
    {
        public double mainfun()
        {
            int outerloop = 0, innerloop = 0;
            double maximumNo = 0, reversed = 0;
            

            for (outerloop = 100; outerloop <= 999; outerloop++)
            {
                for (innerloop = 100; innerloop <= 999; innerloop++)
                {
                    int mul = outerloop * innerloop;

                    while (mul > 0)
                    {
                        reversed = reversed * 10 + mul % 10;
                        mul /= 10;
                    }

                    if (mul == reversed && mul > maximumNo)
                    {
                        maximumNo = mul;
                    }
                }
            }
            Console.Write("Largest Paildrome is:" + maximumNo);
            return maximumNo;
        }
    }
    class LargestPalindrome
    {
        static void Main(string[] args)
        {
            MainFuncation mf = new MainFuncation();
            mf.mainfun();
            Console.ReadKey();
        }
    }
}
