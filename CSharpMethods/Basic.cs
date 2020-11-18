using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpMethods
{
    class Basic
    {

        #region Decimal to Binary. 10 = 1010 (2^3 2^2 2^1 2^0)
        //1. Divide the number by 2. 
        //2. Get the integer quotient for the next iteration. 
        //3. Get the remainder for the binary digit. 
        //4. Repeat the steps until the quotient is equal to 0.
        public string DecimalToBinary()
        {
            string answer;
            string result;

            Console.Write("Input a Number : ");
            answer = Console.ReadLine();

            int num = Convert.ToInt32(answer);
            result = "";

            while (num > 1)
            {
                int remainder = num % 2;
                result = Convert.ToString(remainder) + result;
                num /= 2;
            }

            result = Convert.ToString(num) + result;
            Console.WriteLine("Binary: {0}", result);

            return result;
        }
        #endregion

        #region Display a triangle of specified character and width
        public void DisplayTextTriangle()
        {
            //Console.Write("Input a number: ");
            //int width = Convert.ToInt32( Console.ReadLine() );
            
            char userChar;
            do
            {
                Console.Write("Input a valid character: ");
            } while (!char.TryParse(Console.ReadLine(), out userChar));

            int triangleWidth;
            do
            {
                Console.Write("Input the desired width (number of characters wide): ");
            } while (!int.TryParse(Console.ReadLine(), out triangleWidth));

            int height = triangleWidth;

            Console.WriteLine("Print Upside down");
            for (int row = 0; row < height; row++)
            {
                for (int column = 0; column < triangleWidth; column++)
                {
                    Console.Write(userChar);
                }

                Console.WriteLine();
                triangleWidth--;
            }

            Console.WriteLine("Print Right side up");
            int curTriangleWidth = 1;
            for (int row = 0; row < height; row++)
            {
                for (int column = 0; column < curTriangleWidth; column++)
                {
                    Console.Write(userChar);
                }

                Console.WriteLine();
                curTriangleWidth++;
            }
        }
        #endregion

        #region FizzBuzz: When a number is multiple of three print “Fizz”, if multiple of five then print “Buzz”, if multiple of both three and five print “FizzBuzz”
        public string FizzBuzz()
        {
            StringBuilder returnString = new StringBuilder();

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    //Console.WriteLine("FizzBuzz");
                    returnString.Append("FizzBuzz, ");
                }
                else if (i % 3 == 0)
                {
                    //Console.WriteLine("Fizz");
                    returnString.Append("Fizz, ");
                }
                else if (i % 5 == 0)
                {
                    //Console.WriteLine("Buzz");
                    returnString.Append("Buzz, ");
                }
                else
                {
                    //Console.WriteLine(i);
                    returnString.Append(i + ", ");
                }

                ////Fizz Buzz: Replace number containing 3 with Fizz, containing 5 with Buzz
                //if (i.ToString().Contains("3"))
                //{
                //    returnString.Append("Fizz, ");
                //}
                //else if (i.ToString().Contains("5"))
                //{
                //    returnString.Append("Buzz, ");
                //}
                //else
                //{
                //    returnString.Append(i + ", ");
                //}
            }

            return returnString.ToString();
        }
        #endregion


    }//class Basic
}//namespace CSharpMethods
