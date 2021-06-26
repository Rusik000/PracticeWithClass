using System;
using System.Threading;


namespace Classes
{
    class Program
    {
        public static void Run()
        {
            //Tapsiriq 1

            //var point = new Point(256, 456);
            //point.Show();



            ////Tapsiriq 2 

            //var counterSecond = new Counter(0, 100);

            //for (int i = 0; i < 150; i++)
            //{
            //    if (i == 100)
            //    {

            //        Console.ForegroundColor = ConsoleColor.Green;
            //        Console.WriteLine();
            //    }
            //    Thread.Sleep(500);
            //    Console.WriteLine();
            //    Console.Write(counterSecond.Increment() + " ");
            //}

            //Console.WriteLine();


            ////Tapsiriq 3

            //var first = new Fraction(16, 1);
            //var second = new Fraction(5, 4);


            //Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.Write("First Fraction :");
            //first.Show();
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.Write("Second Fraction :");
            //second.Show();
            //Console.ResetColor();


            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine();
            //Console.WriteLine(first / second);
            //Console.WriteLine(first * second);
            //Console.WriteLine(first + second);
            //Console.WriteLine(first - second);
            //Console.WriteLine();
            //Console.ResetColor();


            //Tapsiriq 4
            Console.ForegroundColor = ConsoleColor.Green;
            var car = new Car(1, "Bmw", "525", 2.5, new DateTime(2002, 10, 8));
            car.Show();
        }

        static void Main(string[] args)
        {

            Run();
        }

    }
}

