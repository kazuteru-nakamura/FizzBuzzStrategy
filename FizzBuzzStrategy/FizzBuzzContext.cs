using System;
using System.Collections.Generic;

namespace FizzBuzzStrategy
{
    public class FizzBuzzContext
    {

        private readonly IList<IFizzBuzz> _fizzbuzz = new List<IFizzBuzz>();

        public void Push(IFizzBuzz fizzbuzz)
        {
            _fizzbuzz.Add(fizzbuzz);
        }

        public string Echo(int value)
        {
            var output = value.ToString();

            foreach (var fb in _fizzbuzz)
            {
                if (fb.Formula(value))
                {
                    output = fb.Output();
                    break;
                }          
            }

            return output;
        }

    }
}
