using System.Collections.Generic;

namespace PatternStrategy
{
   internal class StrategyA : IStrategy
   {
      public object DoSomething(object data)
      {
         var list = data as List<string>;
         list.Sort();
         return list;
      }
   }
}
