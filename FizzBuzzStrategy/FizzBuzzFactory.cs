using FizzBuzzStrategy.Impl;

namespace FizzBuzzStrategy
{
    public class FizzBuzzFactory
    {
        public static FizzBuzzContext Create()
        {
            var c = new FizzBuzzContext();

            c.Push(new FizzBuzzImpl());
            c.Push(new FizzImpl());
            c.Push(new BuzzImpl());

            return c;
        }
    }
}
