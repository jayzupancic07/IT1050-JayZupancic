using System;

namespace Lab5
{
    class Dog
    {
        private int name;

        public string Name { get; private set; }

        static void Main(string[] args)
        {
            /* 2. Identify each of the elements of the method header.
             * a. Scope: the scope of the code is return height * width; listed in the left and right curly brackets. 
             *          This is part of the public method scope and anything in this block of code is accessible to this method since
             *          it is non-static.
             *          
             * b. Static vs Non-Static: The method header is non-static because static is not listed in the header. Being
             *          non-static means if we want to reference getArea in the main method is must first be declared
             *          in the main method. Otherwise the non-static method header needs to become static.
             *          
             * c. Return Type: return height * width; declares that we are returning a statement with a value. In this 
             *          method example, we are returning the value of height * width as a double value.
             *          
             * d. Method Name: The method name is the getArea method. 
             * 
             * e. Parameters:  The parameter list is double height, and double width. This is important to note because it is declaring
             *          that these parameters are only accessible in the getArea method body. 
             * 
             * f. Method body: the method body is the line of code listed in the method. For example, the method body of this
             *          getArea method is the line of code return height * width. 
             */

            /* 3. Explain the difference between a userdefined method and a framework provided method.
             * 
             * A user defined method is a method that is a custom created method. A method provided with a framework uses framework from
             * the .NET library. A programmer must clearly define all parts of a user defined method to ensure the accuracy of the code. It
             * seems best to use them .NET library.
             */

            /* 4. A static method is a method that belongs to the actual class meaning we do not have to create an object of that class
             * to use it and access it. A non static method is a method that a static method cannot access unless we make reference to
             * the class IN the main static method. 
             */

            Dog myDog = new Dog();
            myDog.Name = "Fido";
          
            // To do: uncomment the following lines of code to call the methods
            myDog.bark();
            myDog.doTrick("Fetch");
        }
        public void bark()
        {
            Console.WriteLine("{0} is Barking...", name);
        }
        
        public void doTrick(string trickName)
        {
            Console.WriteLine("{0} is so smart!  {0} is doing a(n) {1}", name, trickName);
        }

    }
}
