using System;

class Error
{
    public static void Main()
    {
        int a = 10;
        int b = 5;
        int c = 5;
        int x;
        int y;

        try
        {
            x = a / (b - c);     // Exception here
        }
        catch (Exception e)
        {
            Console.Write("Value of x : ");
            Console.WriteLine("Division by zero");
        }
        y = a / (b + c);
        Console.WriteLine("Value of y : " + y);
        Console.ReadLine();
    }
}

