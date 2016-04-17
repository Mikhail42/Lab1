using MyNumber = System.Decimal;

namespace SearchRoots.solution
{
    internal class Context
    {
        private AIterationSearchRoot searchRoot;
        public void SetSearchRoot(AIterationSearchRoot searchRoot)
        {
            this.searchRoot = searchRoot;
        }
        public Context(AIterationSearchRoot searchRoot)
        {
            SetSearchRoot(searchRoot);
        }
        public MyNumber ExecuteOperation()
        {
            return searchRoot.Root();
        }
    }
}
