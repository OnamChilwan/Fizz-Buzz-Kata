namespace FizzBuzz.Client
{
    public class FizzBuzz
    {
        public string Execute(int number)
        {
            if (IsNumberDivisiblebyThree(number) && IsNumberDivisibleByFive(number))
                return "FizzBuzz";

            if (IsNumberDivisiblebyThree(number))
                return "Fizz";

            if (IsNumberDivisibleByFive(number))
                return "Buzz";

            return number.ToString();
        }

        private static bool IsNumberDivisibleByFive(int number)
        {
            return number % 5 == 0;
        }

        private static bool IsNumberDivisiblebyThree(int number)
        {
            return number % 3 == 0;
        }
    }
}