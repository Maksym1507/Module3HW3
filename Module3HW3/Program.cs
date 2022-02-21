using System;

namespace Module3HW3
{
    internal class Program
    {
        public static void Show(bool resultDelegate)
        {
            Console.WriteLine(resultDelegate);
        }

        private static void Main()
        {
            var class1 = new Class1 { ShowDelegate = Show };

            var class2 = new Class2();
            class2.Calc(class1.Multiply, 7, 10);

            class1.ShowDelegate(class2.Result(5));
        }
    }
}
