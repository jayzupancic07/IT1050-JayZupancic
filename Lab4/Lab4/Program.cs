using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {

            /* 2. There are 4 basic elements of the counter-controlled repitition.
             * The first is a controlled variable. A controlled variable needs to be declared. For example, int x declared the variable as interger .
             * The second is the value of the controlled variable. The statement int x = 48 declared the value of x as 48.
             * The third is increment or decrement the controlled variable is modified by. An example is ++x meaning the variable is going to increase by the value of 1. 
             * The last is the loop-continuation condition. The statement while (x <= 60) it the condition; the code will continue to execute and count up by 1 until it reachs the value 60.
             */

            /* 3. The for and while repetition statements are similar in the fact that a for statement can be written pretty much as a simplified while statement. 
             * The for statement is used when there is a know number of times we want the program to run versus the while statement where the number of outcomes is unknown.
             */

            /* 4. It would be appropriate to use a do while vs a while statement when we want the block of code to run at least once. 
             * For example, if you wanted to test a variable counter and wanted the program to run at least once.
             * 
             * int a=14
             * 
             * do
             * { 
             * 
             * Console.WriteLine(a++)
             *
             * } while (a>=20);
             * 
             * Console.WriteLine()
             * 
             * This code will run at least once. If the while is written where the do statement is, the code will not execute at all because it is false.
             */



            // 5. Create a for loop that goes from 1-100 using a variable named i as the counter.
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);

                if ((i % 2) == 0)
                {
                    Console.WriteLine("it's even");
                }

                else
                {
                    Console.WriteLine("its odd");
                }

            }

            // 6. Use an if…else-if…else statement to output the following based on an int temp that is input by the user. Prompt the user with “Please enter a temperature”. 
            
            Console.Write("Please enter a temperature: ");

            int temp = Convert.ToInt32(Console.ReadLine());

            if (temp < 10)
            {
                Console.WriteLine("Polar Bear");
            }
            else if (temp < 20)
            {
                Console.WriteLine("Penguine");
            }
            else if (temp < 40)
            {
                Console.WriteLine("Moose");
            }
            else if (temp < 50)
            {
                Console.WriteLine("Reindeer");
            }
            else if (temp < 60)
            {
                Console.WriteLine("Deer");
            }
            else if (temp < 70)
            {
                Console.WriteLine("Turtle");
            }
            else if (temp < 80)
            {
                Console.WriteLine("Lion");
            }
            else if (temp < 90)
            {
                Console.WriteLine("Fish");
            }
            else
            {
                Console.WriteLine("bug");
            }

            /* 7.	The following code is meant to loop and output 10-20, each number on a separate line.  What’s wrong?  
             * Answer: it is missing the counter (i++) So the correct code is...
             */

            int i = 10;
            while (i < 21)
            {
                Console.WriteLine(i++);
            }

            /* 8. The following statement is supposed to output every number from 0-100 separated by a line with asterisks on it.  
             * What is wrong with the code? 
             * Answer: The curly brackets are missing surrounding the Console.WriteLine command so the correct code is...
             */

            for (int i = 0; i < 101; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine("********");
            }
        }
    }
}
