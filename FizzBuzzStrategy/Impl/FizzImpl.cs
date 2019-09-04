namespace FizzBuzzStrategy.Impl
{
    public class FizzImpl : IFizzBuzz
    {
        public string Output()
        {
            return "Fizz";
        }

        public bool Formula(int value)
        {
            return value % 3 == 0;
        }
    }
}
