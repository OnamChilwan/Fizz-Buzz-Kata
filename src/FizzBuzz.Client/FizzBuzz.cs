namespace FizzBuzz.Client
{
    public class FizzBuzz
    {
        public string Execute(int number)
        {
            if (IsNumberDivisibleByThree(number) && IsNumberDivisibleByFive(number))
                return "FizzBuzz";

            if (IsNumberDivisibleByThree(number))
                return "Fizz";

            if (IsNumberDivisibleByFive(number))
                return "Buzz";

            return number.ToString();
        }

        private static bool IsNumberDivisibleByFive(int number)
        {
            return number % 5 == 0;
        }

        private static bool IsNumberDivisibleByThree(int number)
        {
            return number % 3 == 0;
        }
    }
}