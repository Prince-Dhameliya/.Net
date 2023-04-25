using System;

namespace Code_3
{
    public delegate double Maximum(double a, double b);
    class Program
    {
        public static void CallAnonymousMethod()
        {
            bool positive = new Func<int, bool>(delegate (int int32) { return int32 > 0; })(1);
            new Action<bool>(delegate (bool value) { Console.WriteLine(value); })(positive);
        }
        public static void CallLambda()
        {
            bool positive = new Func<int, bool>(int32 => int32 > 0)(1);
            new Action<bool>(value => Console.WriteLine(value))(positive);
        }
        static void Main(string[] args)
        {
            Console.Write("\n1) Without Lamda Expression : ");
            Program.CallAnonymousMethod();

            Console.Write("\n2) Lamda Expression : ");
            Program.CallLambda();

            //delegate with lamda expression
            Console.WriteLine("\n3) Lamda Expression : ");
            Maximum parse = (double x, double y) => (x > y ? x : y);
            Console.WriteLine("Max(25.5,45.2) = {0}", parse(25.5, 45.2));

            Console.WriteLine("\n4) Lamda Expression : ");
            Func<double, double, double> f = (x, y) => { if (x > y) return x; return y; };
            double a1 = f(70,40);
            Console.WriteLine("Max(70,40) = {0}", a1);

            Console.WriteLine("\n5) Lamda Expressions : ");
            double a2;
            Func<double, double, double> f2;
            f2 = (x, y) => {
                if (x > y)
                    return x;
                return y;
            };
            a2 = f2(50, 20);
            Console.WriteLine("Max(50,20) = {0}", a2);

            f2 = (x, y) => {
                if (x < y)
                    return x;
                return y;
            };
            a2 = f2(40, 30);
            Console.WriteLine("Min(40,30) = {0}\n", a2);

        }
    }
}
