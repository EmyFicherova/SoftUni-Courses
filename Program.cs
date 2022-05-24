using System;

namespace Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());

            mins += 30;

            if (mins >= 60)
            {
                mins -= 60;
                hours++;
            }
            if (hours == 24)
            {
                hours = 0;
            }

            Console.WriteLine($"{hours}:{mins:d2}");

        }
    }
}
