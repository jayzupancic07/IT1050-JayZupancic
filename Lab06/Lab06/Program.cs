using System;

namespace Lab06
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 2.	Fill in the blanks in the following statement..
             * p[0], p[1], p[2], p[3]
             */

            //3. Create a 12-element array called months. 

            string[] months = new string[12];

            months[0] = "January";
            months[1] = "February";
            months[2] = "March";
            months[3] = "April";
            months[4] = "May";
            months[5] = "June";
            months[6] = "July";
            months[7] = "August";
            months[8] = "September";
            months[9] = "October";
            months[10] = "November";
            months[11] = "December";

            for (int i=0; i < months.Length; i++)
            {
                Console.WriteLine(months[i]);
            }


            //4.  Create a 4-element array to store the names of 4 seasons.  Use a foreach loop to display the name of each season.

            string[] seasons = new string[] { "Spring", "Summer", "Fall", "Winter" };

            foreach (string i in seasons)

            {
                Console.WriteLine(i);
            }

            // 5. Create an array of integers with 1000 elements.  Fill the array with random numbers.  Use a foreach loop to print all integers in the array.

            int[] array = new int[1000];

            Random random = new Random();
            int randomNumber;
            randomNumber=random.Next(0, 100);

            foreach (int element in array)

            {
                Console.WriteLine(random.Next(0, 100));
            }

            //6. Paste the following code into the main() method.  Modify the code; so that it works

            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            //7. Modify the code from problem 5, so that it outputs a number and then a person’s name using the following output statement.

            int[] array = new int[1000];
            string[] names = new string[100];

            Random random = new Random();
            int randomNumber;
            randomNumber = random.Next(0, 100);
            int i;
            i = name.Length;

            foreach (int element in array)

            {
                Console.WriteLine("{0,2}. {1}", i, names[i]);
            }


            //8. 8.	Modify the code from problem 6, so that it uses a foreach loop as opposed to a while loop.  The output should appear exactly the same as it did after step 2
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            int arrayLength = names.Length;

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }


        }
    }
}
