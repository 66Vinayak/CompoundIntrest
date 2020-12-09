/* 
 COPY RIGHT @AUGMENTO LABS 2020
Created By Vinayak
*/
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CompoundIntrest
{
    public class CompoundInterestTest
    {
        private readonly CalculateCompIntrest _sut;
        public CompoundInterestTest()
        {
            _sut = new CalculateCompIntrest();
        }

        [Fact]
        public void CompoundTest1()
        {
           var result= _sut.CalculateCompoundInterest(1000, 10, 6, 12);
            Assert.Equal(5000, result);
        }

        [Fact]
        public void CompoundTest2()
        {
            var result = _sut.CalculateCompoundInterest(1000, 10, 6, 4);
            Assert.Equal(5000, result);
        }
    }
}
