using System;

namespace EventsDemo
{
    public delegate void Sample(int x);
    class Program
    {
        public static event Sample Sample1Event;
        public static void Notify(int x)
        {
            if (Sample1Event != null)
            {
                Sample1Event(x);
            }
        }
        class User1
        {
            public static void User1Method(int x)
            {
                Console.WriteLine("Event received by User1 object");
            }
        }
        class User2
        {
            public static void User2Method(int x)
            {
                Console.WriteLine("Event received by User2 object");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int i = int.Parse(Console.ReadLine());
            Sample s = new Sample(Square);                                   //instance and set target method 
            s.Invoke(i);                                                    //Invoking the delegate
            Sample1Event += User1.User1Method;
            Sample1Event += User2.User2Method;
            Notify(i);
        }
        static void Square(int x)
        {
            Console.WriteLine(x * x);
        }
    }
}
