using TestDependencyFlows.Library.NetStandard;

namespace TestDependencyFlows.Library
{
    public static class SomeService
    {
        public static string GetSomething()
        {
            return SomeRepository.GetSettings()[0];
        }
    }
}
