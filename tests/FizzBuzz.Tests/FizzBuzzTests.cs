namespace FizzBuzz.Tests
{
    using FizzBuzz.Client;
    using NUnit.Framework;

    [TestFixture]
    public class FizzBuzzTests
    {
        private FizzBuzz subject;
        private string result;

        [SetUp]
        public void Setup()
        {
            this.subject = new FizzBuzz();
        }

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        public void When_A_Number_Divisible_By_Three(int number)
        {
            this.result = this.subject.Execute(number);
            Assert.That(this.result, Is.EqualTo("Fizz"));
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        public void When_A_Number_Divisible_By_Five(int number)
        {
            this.result = this.subject.Execute(number);
            Assert.That(this.result, Is.EqualTo("Buzz"));
        }

        [TestCase(15)]
        [TestCase(30)]
        public void When_A_Number_Divisible_By_Three_And_Five(int number)
        {
            this.result = this.subject.Execute(number);
            Assert.That(this.result, Is.EqualTo("FizzBuzz"));
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(4)]
        public void When_A_Number_Is_Not_Divisible_By_Three_Or_Five(int number)
        {
            this.result = this.subject.Execute(number);
            Assert.That(this.result, Is.EqualTo(number.ToString()));
        }
    }
}