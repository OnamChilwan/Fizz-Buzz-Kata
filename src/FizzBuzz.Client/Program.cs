namespace FizzBuzz.Client
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzz = new FizzBuzz();

            Console.WriteLine("Press 'x' to exit.");

            while (true)
            {
                Console.WriteLine("Please enter a number: ");
                int number;

                if (int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine($"Answer is: {0}", fizzBuzz.Execute(number));
                    continue;
                }

                break;
            }
        }
    }
}
