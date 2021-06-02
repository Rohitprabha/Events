using System;

namespace Events
{
    public delegate void Sample(int x);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int i = int.Parse(Console.ReadLine());
            Sample s;                                   //instance
            s = Square;                                 // point to the method
            s.Invoke(i);                                //Invoking the delegate
            Sample1 obj = new Sample1();
            obj.Sample1Event += User1.User1Method;
            obj.Sample1Event += User2.User2Method;
            obj.Notify(i);
        }
        static void Square(int x)
        {
            Console.WriteLine(x * x);
        }
    }
}
