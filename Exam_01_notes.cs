/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        /*static void Main(string[] args)
        {

            int usCnt = 10; int usSum = 10; 
            if (usSum++ == usCnt) 
                {
                Console.WriteLine("true");                   	
                }
                Console.ReadLine();
            int usCnt = 10; int usSum = 10;
            if (usSum == ++usCnt)
            {
                Console.WriteLine("true");
            }
     
            Console.ReadLine();

            int usSum = 10; int usCnt = 2;
            switch (usCnt)
            {
                case 3:
                    {
                        usSum = usSum + 2;
                        break;
                    }
                default:
                    {
                        break;
                    }
                case 2:
                    {
                        usSum = usSum * 3;
                        goto case 3;
                    }
            }

            Console.WriteLine("usSum = {0}",usSum);
            Console.ReadLine();
            }
        static void Main( )
            {
                int iSum;
                int iCnt = 2, iValue; int iTotal;
                char chChar = 'a';

                iSum = chChar
                ;
                while (iSum == 100)
                {
                    iSum = iSum + 1;
                }
            }


        
    }
}

using System;
class Test
{
    static void Main()
    {
        uint usCnt;
        uint usSum = 0;

        for (usCnt = 10; usCnt >= 0; usCnt--)
        {
            Console.WriteLine("{0}", usCnt);
            usSum = usSum + usCnt;
        }
    }
}*/
using System;
using System.Collections;
class Test
{
    static void Main()
    {
        /*int iX;
        int iY;

        iX = 15321;
        while (iX != 0)
        {
            iY = iX % 10;
            Console.Write(iY);
            iX /= 10;
        }
        Console.WriteLine();
        Console.ReadLine();*/

        Stack stack = new Stack ();
        stack.Push('A');
        stack.Push('B');
        stack.Push('C');
        stack.Push('D');
        stack.Push('E');
        foreach (char letter in stack)
        {
            Console.WriteLine(letter);
        }
        while (stack.Count() != 0)
        {
            Console.WriteLine("Popping {0}", stack.Pop());
        }
        Console.ReadLine();


    }
}

