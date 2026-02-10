using System;

namespace OMG_Krasniqi_Olti
{
    public class Model : IModel
    {
        public int Ggt(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            if (a == 0) return b;
            if (b == 0) return a;

            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }

            return a;
        }
    }
}
