using LabProject.SearchRoots.solution;
using System;

using MyNumber = System.Decimal;

namespace SearchRoots.solution
{
    public class Newton : AIterationSearchRoot
    {
        public static readonly String methodName = "Newton method";

        private MyNumber root0;
        public void SetRoot0(MyNumber root0)
        {
            this.root0 = root0;
        }

        private MyFunction derF;

        public static MyNumber eps = new MyNumber(1e-6);

        public Newton(MyFunction f, MyFunction derF, MyNumber root0) : base(f)
        {
            this.derF = derF;
            SetRoot0(root0);
        }

        public override MyNumber Root()
        {
            MyNumber valF;
            while (Math.Abs(valF = GetF().Invoke(root0)) >= eps)
                root0 -= valF / derF(root0);
            return root0;
        }

        public override String ToString()
        {
            return methodName + Root();
        }
    }
}
