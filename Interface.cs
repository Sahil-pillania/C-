using System;
interface Addition
{
    int Add();
}
interface Multiply
{
    int Mul();
}
class comp : Addition, Multiply
{
    int x;
    int y;
    public comp(int x, int y)  // constructor
    {
        this.x = x;
        this.y = y;
    }
    public int Add()                        // implements Add()
    {
        return (x + y);
    }
    public int Mul()                        // implements mul()
    {
        return (x * y);
    }
}
class Interface
{
    public static void Main()
    {
        comp obj = new comp(10, 20);
        Addition add = (Addition)obj;    // casting
        Console.WriteLine("Sum = " + add.Add());
        Multiply mul = (Multiply)obj;    // casting
        Console.WriteLine("Product = " + mul.Mul());
        Console.ReadLine();
    }
}