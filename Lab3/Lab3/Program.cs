using System;
using System.Collections;

namespace Lab3
{

    /* if single selection and while repititon both have to determine whether the statement is true or false. 
    /They differ because the if single selection only performs the true statement and the while repitition statement 
    will continue performing the true statement until it becomes false.
    */
    //
    class Program
    {
        static void Main(string[] args)
        {
            {
                //Write an if statement that displays “SLOW NOW” if speed is greater than speedLimit.

                int speedLimit;
                int speed;

                speedLimit = 35;
                speed = 42;

                if (speed > speedLimit)
                    Console.WriteLine("SLOW NOW");
            }


            //Write a program that declares and assigns a value to a Boolean variable called isTrue.  
            //Use a condition to output “It is True!” or “It is False!” based on the assigned value

            bool isTrue = true;

            if (isTrue)
            {
                Console.WriteLine("It is True!");
            }
            else
            {
                Console.WriteLine("It is False!");
            }

            bool isTrue = false;

            if (isTrue)
            {
                Console.WriteLine("It is true!");
            }
            else
            {
                Console.WriteLine("It is false!)");
            }

            //Write a program that converts a Fahrenheit temperature to Celsius

            double celsius;
            Console.Write("Fahrenheit temperature : ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("The converted Celsius temperature is " + celsius);

            if (fahrenheit < 40)
            {
                Console.WriteLine("it is cold");
            }
            if (fahrenheit > 90)
            {
                Console.WriteLine("it is hot");
            }

            //outputs values 1 to 10.  Increment by 1
            int x = 10;
            while (x <= 10)
            {
                Console.WriteLine(x++);
            }

            //output 60 to 20 decrement by 5
            int i = 60;
            while (i > 20)
            {
                Console.WriteLine(i -= 5);
            }

            //outputs values 10-20. Increment by 2
            int y = 10;
            while (y <= 20)
            {
                Console.WriteLine(y += 2);
            }

        }

    }


}