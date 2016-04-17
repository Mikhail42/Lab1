using System;
using LabProject.SearchRoots.solution;

using MyNumber = System.Decimal;

namespace SearchRoots.solution
{
    public class Bisection : AIterationSearchRoot
    {
        public const String methodName = "Bisection method";

        private MyNumber a;
        private MyNumber b;

        public Bisection(MyFunction f, MyNumber a, MyNumber b) : base(f)
        {
            this.a = a;
            this.b = b;
        }

        private static bool EqualSign(MyNumber a, MyNumber b)
        {
            return ((a > 0 && b > 0) || (a < 0 & b < 0));
        }

        public override MyNumber Root()
        {
            MyNumber x1 = a;
            MyNumber x2 = b;
            MyNumber medX = (x2 + x1) / 2;
            MyNumber valF1 = GetF().Invoke(x1);
            MyNumber valFMed = GetF().Invoke(medX);
            var eps = new MyNumber(1e-6);
            var quartEps = eps / 4;
            while (Math.Abs(x2 - x1) >= eps)
            {
                if (EqualSign(valF1, valFMed))
                    x1 = medX - quartEps;
                else x2 = medX + quartEps;
                medX = (x2 + x1) / 2;
                valF1 = GetF().Invoke(x1);
                valFMed = GetF().Invoke(medX);
            }
            return medX;
        }
    }
}
