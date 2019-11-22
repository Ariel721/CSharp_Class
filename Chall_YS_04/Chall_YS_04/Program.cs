using System;

class program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Welcome, enter a string of 8 letters max:"); //get string 
            string inpt = Console.ReadLine();
            char[] arrComp = new char[inpt.Length];// Create another array to copy string in reverse order

            if (inpt.Length > 8) // check if input string 
            {
                Console.WriteLine("Invalid input... try again"); //if true return invalid input message
                Console.ReadLine();
            }
            else
            {
                char[] arr = new char[inpt.Length]; //Create primary array
                arr = inpt.ToCharArray(0, inpt.Length); //insert each character of string into array 
                int indx = 0;
                ;

                for (int i = inpt.Length - 1; i >= 0; i--) //reverse the string
                {
                    arrComp[indx] = arr[i];
                    indx++;
                }

                string chkStr = new string(arrComp);// compare the strings 
                if (inpt == chkStr)
                {
                    Console.WriteLine("Your string \"{0}\" is palindrome\n", inpt); 
                }
                else
                {
                    Console.WriteLine("Your string \"{0}\" is not palindrome\n", inpt);
                }
            }
        }
    }
}