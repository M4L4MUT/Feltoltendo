using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testek
{
    internal class Program

    {
        static List<Test> test = new List<Test>();
        static void Main(string[] args)
        {
            test.Add(new Teglatest(2,4,5));
            test.Add(new Kocka(4));
            test.Add(new Henger(2, 10));

            foreach(var item in test)
            {
                if (item.GetType().Equals(typeof(Teglatest)))
                {
                    Teglatest teglatest = (Teglatest)item;
                    Console.WriteLine($"A téglatest térfogata: {teglatest.Terfogat()} - felszíne: {teglatest.Felszin()}");
                }
                else if (item.GetType().Equals(typeof(Kocka)))
                { 
                    Kocka kocka = (Kocka)item;
                    Console.WriteLine($"A kocka térfogata: {kocka.Terfogat()} - felszíne: {kocka.Felszin()}");
                }
                else if (item.GetType().Equals(typeof(Henger)))
                {
                    Henger henger = (Henger)item;
                    Console.WriteLine($"A henger térfogata: {henger.Terfogat()} - felszíne: {henger.Felszin()}");
                }
            }
            Console.WriteLine("Program vége");
            Console.ReadLine();
        }
    }
}