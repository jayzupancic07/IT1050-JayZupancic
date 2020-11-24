using System;

namespace Lab05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Identify the elements of the method header.
             * Scope: the scope of the code is return height* width; listed in the left and right curly brackets.
             * This is part of the public method scope and anything in this block of code is accessible to this method since
             * it is non-static.
             * 
             * static vs non static: the method header is non-static because static is not listed in the header. Being non-static means
             *  if we want to reference getArea in the main method it must first be declared in the main method. Otherwise the
             *  non-static method header needs to become static.
             *  
             *  return type: return height * width; declares that we are returning a statement with a value. In this method example,
             *  we are returning the value of height * width as a double value.
             *  
             *  method name: The method name is getArea
             *  
             *  Parameters: The parameter list is double height and double width. This is important to note  because it is declaring
             *  that these parameters are only accessible in the getArea method body.
             *  
             *  method body: the method body is the line of code listed in the method. For example, the method body of this getArea
             *  method is the line of code return height * width.
             *  */
             
             /*3. Explain the difference between a user defined method and framework provided method.
             *  
             *  A user defined method is a method that is a custom created method. A method provided with framework uses framework from
             *  the .NET library. A programmer must clearly define all parts of a user defined method to ensure the accuracy of the code.
             *  It seems best to use the .NET library.
             *  
             */

             /* 4. A static method is a method that belongs to the actual class meaning we do not have to create an object of that class
              * to use it and access it. A non static method is a method that a static method cannot access unless we make reference to 
              * the class in the main method.
              */
        }
    }
}
