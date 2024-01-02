using System;
using System.Collections.Generic;

namespace PatternStrategy
{
   internal class Context
   {
      private IStrategy _strategy;

      public Context(IStrategy strategy)
      {
         _strategy = strategy;
      }

      public Context()
      {

      }

      public void SetStrategy(IStrategy strategy)
      {
         _strategy = strategy;
      }
      public void DoSomeBusinesslogic()
      {
         Console.WriteLine("Context: Sorting data using the strategy (not sure how it'll do it)");
         var result = _strategy.DoSomething(new List<string> { "a", "b", "c", "d", "e", "main Bus B", "eric", "jean", "main C", "main AC", "main B off", "main A" });
         string resultStr = string.Empty;
         foreach (var element in result as List<string>)
         {
            resultStr += element + ",";
         }

         Console.WriteLine(resultStr);
      }
   }
}
