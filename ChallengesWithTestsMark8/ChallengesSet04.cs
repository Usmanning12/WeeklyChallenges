using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            return numbers.Where( x => x % 2 == 0).Sum()- numbers.Where(x => x % 2 != 0).Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            return new [] { str1, str2, str3, str4 }.Min( s => s.Length );
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return new List<int> { number1, number2, number3, number4 }.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders"; 
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 < 0 || sideLength2 < 0 || sideLength3 < 0)
                return false; 
            if (sideLength1 + sideLength2 > sideLength3 && 
                sideLength1 + sideLength3 > sideLength2 && 
                sideLength2 + sideLength3 > sideLength1)
            {
                return true; 
            }
            return false;
        }

        public bool IsStringANumber(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false; 
            return double.TryParse(input, out _);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            if (objs == null || objs.Length == 0)
                return false;
            int nullCount = objs.Count( x => x == null );
            return nullCount > objs.Length / 2; 
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return 0;
            int sum = 0;
            int count = 0;
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                    count++;
                }
            }
            return count == 0 ? 0 : (double)sum / count;
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("number");
                
            }
            int result = 1;

            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;

        }
    }
}
