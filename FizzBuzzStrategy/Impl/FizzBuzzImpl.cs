namespace FizzBuzzStrategy.Impl
{
    public class FizzBuzzImpl : IFizzBuzz
    {
        public string Output()
        {
            return "FizzBuzz";
        }

        public bool Formula(int value)
        {
            return (value % 5 == 0) && (value % 3 == 0);
        }
    }
}
