using System;
using System.Collections.Generic;

namespace TestDependencyFlows.Library.NetStandard
{
    public static class SomeRepository
    {
        public static List<string> GetSettings()
        {
            // Some code that can't be optimised away
            Action<Type> noop = _ => { };
            var typeHook = typeof(System.Data.SqlClient.SqlClientFactory);
            noop(typeHook);

            return new List<string> { "Found data !" };
        }
    }
}
