using System;

namespace Events_Example1
{
    public delegate void SampleDelegate();
    class Program
    {
        public static event SampleDelegate Message;
        public static void Welcome()
        {
            Console.WriteLine("Welcome Rohit");
        }
        public static void Greetings()
        {
            Message();
        }
        static void Main(string[] args)
        {
            Message += new SampleDelegate(Welcome);
            Greetings();
        }
    }
}
