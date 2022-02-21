using System;

namespace Module3HW3
{
    public class Class2
    {
        private int MultiplyResult { get; set; }

        public bool Result(int number)
        {
            return MultiplyResult % number == 0;
        }

        public Predicate<int> Calc(Func<int, int, int> multiplyDelegate, int firstValue, int secondValue)
        {
            MultiplyResult = multiplyDelegate.Invoke(firstValue, secondValue);
            return new Predicate<int>(Result);
        }
    }
}
