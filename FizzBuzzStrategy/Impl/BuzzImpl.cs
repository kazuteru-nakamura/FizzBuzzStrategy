namespace FizzBuzzStrategy.Impl
{
    public class BuzzImpl : IFizzBuzz
    {
        public string Output()
        {
            return "Buzz";
        }

        public bool Formula(int value)
        {
            return value % 5 == 0;
        }
    }
}
