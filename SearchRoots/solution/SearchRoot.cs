using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

using MyNumber = System.Decimal;

namespace LabProject.SearchRoots.solution
{
    internal static class SearchRoot
    {
        public delegate MyNumber MyFunction(MyNumber x);
        public abstract class AIterationSearchRoot
        {
            public const String methodName = "Iteration method";
            
            private MyFunction f;
            public MyFunction getF() {
                return f;
            }
            protected void setF(MyFunction f) {
                this.f = f;
            }

            public AIterationSearchRoot(MyFunction f)
            {
                setF(f);
            }
        }
        public class Newton : AIterationSearchRoot
        {
            public const String methodName = "Newton method";
            private MyFunction derF;
            public Newton(MyFunction f, MyFunction derF) : base(f) {
                this.derF = derF;
            }

            public MyNumber root(MyNumber root0)
            {
                MyNumber root = root0;
                MyNumber valF;
                var eps = new MyNumber(1e-6);
                while (Math.Abs(valF = getF().Invoke(root)) >= eps) root -= valF / derF(root);
                return root;
            }
        }

        public class Bisection : AIterationSearchRoot
        {
            public const String methodName = "Bisection method";

            public Bisection(MyFunction f) : base(f) { }

            private static bool equalSign(MyNumber a, MyNumber b){
                return ((a > 0 && b > 0) || (a < 0 & b < 0));
            }

            public MyNumber root(MyNumber a, MyNumber b)
            {
                MyNumber x1 = a;
                MyNumber x2 = b;
                MyNumber medX = (x2-x1)/2;
                MyNumber valF1 = getF().Invoke(x1);
                MyNumber valFMed = getF().Invoke(medX);
                var eps = new MyNumber(1e-6);
                var quartEps = eps / 4;
                while (Math.Abs(x2-x1) >= eps)
                {
                    if (equalSign(valF1, valFMed)) x1 = medX - quartEps;
                    else x2 = medX + quartEps;
                    medX = (x2 - x1) / 2;
                    valF1 = getF().Invoke(x1);
                    valFMed = getF().Invoke(medX);
                }
                return valFMed;
            }
        }
    }
}
