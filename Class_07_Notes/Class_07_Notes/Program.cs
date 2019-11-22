/*using System;

class Program
{
    static void Main()
    {
        var x = 11;
        var y = 22;

        Swap(ref x, ref y);

        Console.WriteLine("X={0} should be 22", x);
        Console.WriteLine("Y={0} should be 11", y);
        Console.ReadLine();
    }

    // Write the Swap method so that
    // the two values passed in are swapped.
    
    


        static void Swap(ref int first, ref int second)
        {
        public int X;
        public int Y;
        X = y;
        Y = x;
        }
    
}

using System;

class Point
{
    private int X;
    private int Y;

    // public Constructor
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void IncrementXBy(int x)
    {
        X = X + x;
    }
    public void IncrementXBy(long x)
    {
        X = X + (int)x;
    }
    public void IncrementXBy(double x)
    {
        X = X + (int)x;
    }
}

class Program
{
    static void Main()
    {
        var pt = new Point(10, 20);

        // Call int version because
        // 2 is an integer
        pt.IncrementXBy(2);

        // Call long version because
        // 2 is cast as a long integer
        pt.IncrementXBy((long)2);

        // Call double version because
        // 3.4 is a double
        pt.IncrementXBy(3.4);

        Console.ReadLine();
    }
}

using System;

class Point
{
    private int x;
    private int y;

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public Point(double x, double y)
    {
        this.x += (int) x;
        this.y += (int) y;
    }

    public void Add(int x, int y)
    {
        this.x += x;
        this.y += y;
    }
    public void Add(Point point)
    {
        x += point.x;
        y += point.y;
    }
    public int GetX()
    {
        return x;
    }

    public int GetY()
    {
        return y;
    }
}

class Program
{
    static void Main()
    {
        // TODO: Define an overloaded constructor
        // that takes two doubles and casts them to integers
        var myPoint = new Point(10.0, 20.0);

        myPoint.Add(11, 22);

        Console.WriteLine("X={0} Y={1}", myPoint.GetX(), myPoint.GetY());

        var secondPoint = new Point(1000, 2000);

        // TODO: Add overloaded Add method that takes a Point
        myPoint.Add(secondPoint);

        Console.WriteLine("X={0} Y={1}", myPoint.GetX(), myPoint.GetY());

        Console.ReadLine();
    }
}
using System;

class Point
{
    private int x;
    private int y;

    public int X
    {
        get
        {
            return x;
        }
        /*set
        {
            x = value;  not allowing to set 
        }
    }
    public int Y
    {
        get
        {
            return y;
        }
        set
        {
            y = value;
        }
    }
}


class TestClass
{
    static void Main()
    {
        var pt = new Point();

        pt.X = 5;
        pt.Y = 14;

        Console.WriteLine("pt is {0},{1}", pt.X, pt.Y);
    }
}
// Class Exercise No. 1
// Rewrite TV Class, use properties instead of methods

class Television
{
    private int channel = 0;
    private int volume = 0;
    private bool isOn = false;

    public bool On
    {
        get
        {
            return isOn;// do code here
        }
        set
        {
            isOn = value;
            /*if (isOn)
            {
                // do code here
            }
            else
            {
                // do the code to turn the tv OFF
            }
        }
    }

    public int Volume
    {
        get
        {
            return volume;
        }
        set
        {
            if (value >= 0 && value <= 100)
            {
                Volume = value;// do the code to change the volume
            }
        }
    }

    public int Channel
    {
        get
        {
            return channel;// do the code to return the channel
        }
        set
        {
            if (value > 0 && value < 50)
            {
                channel = value; // do the code to change the
                // channel on the tv
            }
        }
    }
}

class pex1
{
    static void Main()
    {
        var tv = new Television();

        if (tv.On == false)
        {
            tv.On = true;
        }

        tv.Channel = 3;

        tv.Volume++;
        tv.Volume++;
        tv.Volume++;
        tv.Volume++;

        tv.On = false;
    }
}*/


/*                char[] arr;
                arr = inpt.ToCharArray(0, inpt.Length);
                int inptInt = inpt.Length;
                switch (inptInt)
                {
                case 1:
                    string isPol = "Yes";
                Console.WriteLine("Is the string palindrome: ", isPol);
                break;
                case 2:
                string isPol = "Yes";
                Console.WriteLine("Is the string palindrome: ", isPol);
                break;
*/
