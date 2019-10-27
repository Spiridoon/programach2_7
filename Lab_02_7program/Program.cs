using System;

namespace Lab_02_7program
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Clear();
                Console.Write("Write day: ");
                byte day = Byte.Parse(Console.ReadLine());
                Console.Write("Write month: ");
                byte month = Byte.Parse(Console.ReadLine());
                Console.Write("Write month: ");
                ushort year = UInt16.Parse(Console.ReadLine());
                if (day < 32 && month < 13)
                {
                    if (day < 10 && month < 10)
                    {
                        Console.WriteLine($"The date is 0{day}/0{month}/{year}");
                    }
                    else if (month < 10)
                    {
                        Console.WriteLine($"The date is {day}/0{month}/{year}");
                    }
                    else if (day < 10)
                    {
                        Console.WriteLine($"The date is 0{day}/{month}/{year}");
                    }
                    else
                    {
                        Console.WriteLine($"The date is {day}/{month}/{year}");
                    }
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Incorrect month or day. Try again");
                    Console.ReadKey();
                    Program.Main(args);
                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Error.. Try again");
                Console.ReadKey();
                Program.Main(args);
            }
        }
    }
}
