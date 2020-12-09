/* 
 COPY RIGHT @AUGMENTO LABS 2020
Created By Vinayak
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CompoundIntrest
{
   public class CalculateCompIntrest
    {
        public  double CalculateCompoundInterest(double amount,int years,float roi,int annualCompound)
        {
            double result = 0;
            
            result = amount * Math.Pow((1 + (roi / annualCompound)), (annualCompound * years));
            return result;
        }
    }
}
