using System;

namespace Tu_khoa_dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "HowKteam ";
            string Mission = "Free Education";
            dynamic DynamicName = Name;
            Console.WriteLine("Mission of " + DynamicName + " is " + Mission);
            Console.ReadKey();
        }
    }
}
