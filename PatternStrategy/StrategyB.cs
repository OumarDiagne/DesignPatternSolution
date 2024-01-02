using System.Collections.Generic;

namespace PatternStrategy
{
   internal class StrategyB : IStrategy
   {
      public object DoSomething(object data)
      {
         var list = data as List<string>;
         list.Sort();
         list.Reverse();
         return list;
      }
   }
}
