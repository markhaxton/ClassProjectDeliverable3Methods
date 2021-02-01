/*
    Author: Mark Haxton
    Date: 1/30/2021
    Comments: This C# Console application code demonstrates the use of
              methods after getting input from a user.  
*/
using System;

namespace ClassProjectDeliverable3Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a sample of a method.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);
            MyMethod();

        }
        static void MyMethod()
        {
            Console.Write("Please enter your name: ");
            string yourName = Console.ReadLine();
            Console.WriteLine("Hello " + yourName + "!");
            
        }

    } // End of class
} // End of namespace