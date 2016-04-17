using LabProject.SearchRoots.solution;

using MyNumber = System.Decimal;

namespace SearchRoots.solution
{
    public abstract class AIterationSearchRoot
    {
        private MyFunction f;
        public MyFunction GetF()
        {
            return f;
        }
        protected void SetF(MyFunction f)
        {
            this.f = f;
        }

        public abstract MyNumber Root();

        public AIterationSearchRoot(MyFunction f)
        {
            SetF(f);
        }
    }
}
