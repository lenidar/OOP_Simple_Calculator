using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool repeat = false;

            do 
            {
                repeat = false;
                Console.Clear();
                performOperation(getOperationFromUser(), getNumFromUser(), getNumFromUser());

                Console.WriteLine("Would you like to try again? [1] Yes");
                if(getNumFromUser() == 1)
                    repeat = true;

            }while(repeat);

            Console.WriteLine("Thank you for using the simple calculator... Press any key to quit...");
            Console.ReadKey();
        }

        /// <summary>
        /// This method ask the user for a number, parses it automatically.
        /// If the parse fails, it will recur until a successful parse.
        /// </summary>
        /// <returns>the number form of the input</returns>
        static int getNumFromUser()
        {
            int num = 0;
            string uInput = "";
            bool isNum = false;

            //Console.Clear();

            Console.Write("Please input a number : ");
            uInput = Console.ReadLine();

            isNum = int.TryParse(uInput, out num);

            if (!isNum)
            {
                Console.WriteLine("{0} is not a number... Press any key to continue...", uInput);
                Console.ReadKey();
                num = getNumFromUser();
            }

            return num;
        }

        /// <summary>
        /// This asks asks for the numeric counterpart of the operations
        /// This method ask the user for a number, parses it automatically.
        /// If the parse fails, it will recur until a successful parse.
        /// </summary>
        /// <returns>the number form of the input</returns>
        static int getOperationFromUser()
        {
            int num = 0;
            string uInput = "";
            bool isNum = false;

            //Console.Clear();

            Console.WriteLine("What operation do you wish to perform : ");
            Console.WriteLine("\t1 - Addition\n\t2 - Subtraction\n\t3 - Multiplication\n\t4 - Division\n\t5 - Modulo\n");
            uInput = Console.ReadLine();

            isNum = int.TryParse(uInput, out num);

            if (!isNum)
            {
                Console.WriteLine("{0} is not a number... Press any key to continue...", uInput);
                Console.ReadKey();
                num = getOperationFromUser();
            }

            if (num < 0 || num > 6)
            {
                Console.WriteLine("{0} does not correspond to a valid operation... Press any key to continue...", uInput);
                Console.ReadKey();
                num = getOperationFromUser();
            }

            return num;
        }

        /// <summary>
        /// This method performs the operation necessary
        /// </summary>
        /// <param name="a">Numeric counterpart for the operation</param>
        /// <param name="b">Number 1 the operation will be performed on</param>
        /// <param name="c">Number 2 the operation will be performed on</param>
        static void performOperation(int a, int b, int c)
        {
            Console.WriteLine();
            switch(a)
            {
                case 1:
                    addition(b, c);
                    break;
                case 2:
                    subtraction(b, c);
                    break;
                case 3:
                    multiplication(b, c);
                    break;
                case 4:
                    division(b, c);
                    break;
                case 5:
                    modulo(b, c);
                    break;
            }

            //Console.WriteLine("{0} {1} {2} = {3}", b, '+', c, modifiedAddition(b,c));

            Console.WriteLine("\nPress any key to continue. . .");
            Console.ReadKey();

        }

        /// <summary>
        /// Adds the two numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void addition(int a, int b)
        {
            Console.WriteLine("The sum of {0} and {1} is {2}.", a,b,a+b);
        }

        /// <summary>
        /// Determines which number is greater, subtracts the second number from that number
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void subtraction(int a, int b)
        {
            if(a > b)
                Console.WriteLine("The difference of {0} and {1} is {2}.", a, b, a - b);
            else
                Console.WriteLine("The difference of {0} and {1} is {2}.", b, a, b - a);
        }

        /// <summary>
        /// Multiplies the two numbers together
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void multiplication(int a, int b)
        {
            Console.WriteLine("The product of {0} and {1} is {2}.", a, b, a * b);
        }

        /// <summary>
        /// Determines which number is greater, divides the second number from that number
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void division(int a, int b)
        {
            if (a > b)
                Console.WriteLine("The quotient of {0} and {1} is {2}.", a, b, (double)(a / b));
            else
                Console.WriteLine("The quotient of {0} and {1} is {2}.", b, a, (double)(b / a));
        }

        /// <summary>
        /// Gets the modulo of the two numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void modulo(int a, int b)
        {
            Console.WriteLine("The remainder of the division of {0} and {1} is {2}.", a, b, a % b);
        }

        static int modifiedAddition(int a, int b)
        {
            return a + b;
        }
    }
}
