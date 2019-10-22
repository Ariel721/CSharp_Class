//Assignment #4 Ariel Garcia
//This program calculates the factorial of a small integer 
//entered by the user

using System;


namespace Assignment04
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the factorial calculator for small integers"); //Greet User
            Console.Write("Please enter a small integer:"); //Ask user to enter integer
            string FactIndexSt =Console.ReadLine(); //assign read value to string
            int FactIndexInt = int.Parse(FactIndexSt); //explicitly convert string type to int type
            int Fact=FactIndexInt-1; //initialize variables 

            while (Fact>0) //loop
            {
                FactIndexInt = FactIndexInt * Fact; //calculate
                Fact = --Fact; //set index to -1

            }

            Console.WriteLine("The factorial of {0} is: {1}", FactIndexSt, FactIndexInt);
            Console.ReadLine();

        }
    }
}
// End of Assignment #4 Ariel Garcia