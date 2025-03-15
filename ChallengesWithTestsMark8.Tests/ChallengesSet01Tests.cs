using System;
using System.ComponentModel.Design;
using Xunit;

namespace ChallengesWithTestsMark8.Tests
{
    public class ChallengesSet01Tests
    {
        [Theory]
        [InlineData(1, 1, true)]
        [InlineData(10, 10, true)]
        [InlineData(99, 99, true)]
        [InlineData(-10, -10, true)]
        [InlineData(-1, -1, true)]
        [InlineData(0, 1, false)]
        [InlineData(4, 7, false)]
        [InlineData(-1, 1, false)]
        [InlineData(5, 6, false)]
        public bool AreTwoNumbersTheSame(int number1, int number2, bool expected)
        {
            if (number1 == number2)
            {
                return true;
            }
            else
            {
                return false; 
            }
            
            
        }  
        

        [Theory]
        [InlineData(10, 7, 3)]
        [InlineData(100, 75, 25)]
        [InlineData(1, 1, 0)]
        [InlineData(10, 15, -5)]
        [InlineData(0, 7, -7)]
        [InlineData(0, 0, 0)]
        [InlineData(-5, 5, -10)]
        [InlineData(-10, -7, -3)]
        [InlineData(-10, -15, 5)]
        [InlineData(5.5, 1.2, 4.3)]
        [InlineData(0.7, 0.35, 0.35)]
        [InlineData(-2.2, 1.1, -3.3)]
        public double Subtract(double minuend, double subtrahend, double expectedDifference)
        {
            return minuend - subtrahend;
        }

        [Theory]
        [InlineData(10, 7, 17)]
        [InlineData(100, 75, 175)]
        [InlineData(1, 1, 2)]
        [InlineData(10, 15, 25)]
        [InlineData(0, 7, 7)]
        [InlineData(0, 0, 0)]
        [InlineData(-5, 5, 0)]
        [InlineData(-10, -7, -17)]
        [InlineData(-10, -15, -25)]
        public int Add(int addend1, int addend2, int expectedSum)
        {
           
            return addend1 + addend2;
        }

        [Theory]
        [InlineData(10, 7, 7)]
        [InlineData(100, 75, 75)]
        [InlineData(1, 1, 1)]
        [InlineData(10, 15, 10)]
        [InlineData(0, 7, 0)]
        [InlineData(0, 0, 0)]
        [InlineData(-5, 5, -5)]
        [InlineData(-10, -7, -10)]
        [InlineData(-10, -15, -15)]
        public void GetSmallestNumber(int number1, int number2, int expected)
        {
            if (number1 <= number2)
            {
                Console.WriteLine("This is the smallest number");
            }

            else
            {
                Console.WriteLine("This number is the largest number");
            }
        }
        

        [Theory]
        [InlineData(10, 7, 70)]
        [InlineData(100, 75, 7500)]
        [InlineData(1, 1, 1)]
        [InlineData(10, 15, 150)]
        [InlineData(0, 7, 0)]
        [InlineData(0, 0, 0)]
        [InlineData(-5, 5, -25)]
        [InlineData(-10, -7, 70)]
        [InlineData(-10, -15, 150)]
        [InlineData(1234567, 7654321, 9449772114007)]
        [InlineData(1234567, -7654321, -9449772114007)]
        public void Multiply(long factor1, long factor2, long product)
        {
            while (factor1 * factor2 == product)
            { 
                Console.WriteLine("This is the answer of multiplication");  
            }

        }

        [Theory]
        [InlineData("John", "Hello, John!")]
        [InlineData("Leigh", "Hello, Leigh!")]
        [InlineData("John Thomas", "Hello, John Thomas!")]
        [InlineData("Leigh Ann", "Hello, Leigh Ann!")]
        [InlineData("", "Hello!")]
        // [InlineData(null, "Hello!")] // Assumption: string will not be null
        public  string GetGreeting(string personName, string expectedGreeting)
        {
            if (personName == "")
            {
                return "Hello";
            }
            else
            {
                return $"Hello, {personName}";
            }
            
        }

        public string Gethhey()
        {
            return "Hey!";
        }
    }
}
