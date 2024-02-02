using System;

namespace uppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Namn = new List<string>();
            Console.WriteLine("Skriv in vafritt antal namn");
            Console.WriteLine("avsluta genom att skriva en blank rad");
            string namn = "x";
            while (namn != "")
            {
                namn = Console.ReadLine();
                Namn.Add(namn);
            }
            Namn.Sort();
            Namn.Reverse();
            foreach(string element in Namn)
            {
                Console.WriteLine(element);
            }
        }
    }
}