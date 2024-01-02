using System.Collections.Generic;
using System.Linq;

namespace PatternStrategy
{
   internal class StrategyC : IStrategy
   {
      public object DoSomething(object data)
      {
         var list = data as List<string>;
         var res = list.Where(s => s.Contains("main")).ToList();
         res.Sort();
         return res;

      }
   }
}
