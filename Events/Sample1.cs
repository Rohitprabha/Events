using System;

namespace Events
{
    class Sample1
    {
        public event Sample Sample1Event;
        public void Notify(int x)
        {
            if (Sample1Event != null)
            {
                Sample1Event(x);
            }
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
}
