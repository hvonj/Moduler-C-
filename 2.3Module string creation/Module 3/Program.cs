using System;

namespace Module_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("When did you go to bed yesterday?");
            string str = Console.ReadLine();
            int sleepNow = Convert.ToInt32(str);

            Console.WriteLine("When did you wake up?");
            string wakeNow = Console.ReadLine();
            int wake = Convert.ToInt32(wakeNow);

            int tidNu = str - wakeNow;

            if (tidNu >= 8)
            {

                Console.WriteLine("Du har fått tillräckligt med sömn!");
            }
            else
                Console.WriteLine("Du behöver mer sömn!");
        }
    }
}
