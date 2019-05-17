using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Lab17
{
    public class PrimeNumberTest
    {   
        [Fact]
        public void PrimeTest()
        {

            int actual = PrimeNumberGenerator.GetPrimeNumber(1);
            int expected = 2;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void PrimeTest2()
        {
            int actual = PrimeNumberGenerator.GetPrimeNumber(2);
            int expected = 3;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void PrimeTest3()
        {
            int actual = PrimeNumberGenerator.GetPrimeNumber(3);
            int expected = 5;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void PrimeTest4()
        {
            int actual = PrimeNumberGenerator.GetPrimeNumber(4);
            int expected = 7;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void PrimeTest5()
        {
            int actual = PrimeNumberGenerator.GetPrimeNumber(5);
            int expected = 11;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void PrimeTest6()
        {
            int actual = PrimeNumberGenerator.GetPrimeNumber(6);
            int expected = 13;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void PrimeTest7()
        {
            int actual = PrimeNumberGenerator.GetPrimeNumber(7);
            int expected = 17;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void PrimeTest8()
        {
            int actual = PrimeNumberGenerator.GetPrimeNumber(8);
            int expected = 19;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void PrimeTest9()
        {
            int actual = PrimeNumberGenerator.GetPrimeNumber(9);
            int expected = 23;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void PrimeTest10()
        {
            int actual = PrimeNumberGenerator.GetPrimeNumber(10);
            int expected = 29;
            Assert.Equal(expected, actual);
        }
    }
}
