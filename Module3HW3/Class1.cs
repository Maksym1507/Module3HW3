using System;

namespace Module3HW3
{
    public class Class1
    {
        public Action<bool> ShowDelegate { get; set; }

        public int Multiply(int firstValue, int secondValue) => firstValue * secondValue;
    }
}
