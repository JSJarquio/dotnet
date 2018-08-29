using System;

namespace BranchesAndLoops
{
    class Program
    {

        static void ExploreIf()
        {
            int a = 5;
            int b = 5;
            Console.WriteLine("Entering first if statement:");
            if (a + b > 10)
            {
                Console.WriteLine("The answer is greater than 10.");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10.");
            }

            int c = 4;
            Console.WriteLine("Entering second if statement:");
            if ((a + b + c > 10) & (a > b))
            {
                Console.WriteLine("The answer is greater than 10;");
                Console.WriteLine("And the first number is greater than the second.");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10;");
                Console.WriteLine("Or the first number is not greater than the second.");
            }
        }

        static void HelloUniverse()
        {
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello Universe! The counter is {counter}.");
                counter++;
            }
        }

        static void HereComestheSun()
        {
            int counter = 0;
            do
            {
                Console.WriteLine($"Here Comes the Sun! The counter is {counter}");
                counter++;
            } while (counter < 10);
        }

        static void HelloWorld()
        {
            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine($"Hello World! The index is {index}");
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Performing ExploreIf()");
            ExploreIf();

            Console.WriteLine("Performing HelloUniverse()");
            HelloUniverse();

            Console.WriteLine("Performing HereComestheSun()");
            HereComestheSun();

            Console.WriteLine("Performing HelloWorld()");
            HelloWorld();

            int num = 0;
            int sumNum = 0;
            while (num <= 20)
            {
                if ((num > 0) && (num % 3 == 0))
                {
                    sumNum += num;
                    Console.WriteLine(num + " is evenly divisible by 3.");
                }
                num++;
            }
            Console.WriteLine("The sum of all numbers between 0 and 20 that are evenly divisible by 3 is: " + sumNum);

        }
    }
}
