using System;
using System.CodeDom.Compiler;

namespace Uppgift4_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programmet kommer att rita ut en rätvinklig triangel.");
            Console.WriteLine("Bestäm sidlängden på triangeln.");
            int längd = int.Parse(Console.ReadLine());

            for (int i = 0; i < längd; i++)
            {
                string tecken = new string('*', i+1);
                Console.WriteLine(tecken);
            }
        }
    }
}