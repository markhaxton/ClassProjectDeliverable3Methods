/*
    Author: Mark Haxton
    Date: 2/1/2021
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
            Console.ReadKey(true); //This pauses the app until user interacts
            MyMethod(); //This calls the method

        } //end of main
        static void MyMethod()  //This is the method which prints a persons name
        {
            Console.Write("Please enter your name: ");
            string yourName = Console.ReadLine(); //Variable to store users name
            Console.WriteLine("Hello " + yourName + "!"); //Prints the name
            
        } //end of method

    } // End of class
} // End of namespace