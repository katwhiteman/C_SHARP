using System;

namespace MethodDrill
{
    class Class1
    {
        public void Math(out int x, out int y)
        {
            x = 100;
            y = 50 + x;
        }

        public void Math2(out int a, out int b)
        {
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine()) + a;

        }
    }
}
