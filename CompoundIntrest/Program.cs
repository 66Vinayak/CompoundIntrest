/* 
 COPY RIGHT @AUGMENTO LABS 2020
Created By Vinayak
*/
using System;

namespace CompoundIntrest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Compound Intrest----");
            int years;
            int annualCompound;

            float rateOfIntrest;
            double amount;

            Console.WriteLine("Enter principal Amount:");
            amount = double.Parse(Console.ReadLine());

            Console.Write("Enter the rate of interest : ");
            rateOfIntrest = float.Parse(Console.ReadLine()) / 100;

            Console.Write("Enter the total number of years : ");
            years = int.Parse(Console.ReadLine());

            Console.Write("Compounding frequency quarterly or monthly : ");
            annualCompound = int.Parse(Console.ReadLine());
            CalculateCompIntrest compIntrest1 = new CalculateCompIntrest();
            var result = compIntrest1.CalculateCompoundInterest(amount, years, rateOfIntrest, annualCompound);
            Console.Write("After "+years+" years there will be a "+result+" in the Account");
        }
    }
}
