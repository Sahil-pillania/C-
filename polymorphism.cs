using System;

class Tata
{
    public virtual void Display()  // method
    {
        Console.WriteLine("Tata car");
    }
}
class Safari : Tata
{
    public override void Display()  // method
    {
        Console.WriteLine("Tata Safari");
    }
}
class Nexon : Tata
{
    public override void Display()  // method
    {
        Console.WriteLine("Tata Nexon");
    }
}
class PolymorphismInclusion
{
    public static void Main()
    {
        Tata car = new Tata();
        car = new Safari();    // upcasting
        car.Display();

        car = new Nexon();
        car.Display();         // upcasting
        Console.ReadLine();
    }
}
