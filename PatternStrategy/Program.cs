using System;

namespace PatternStrategy
{
   internal class Program
   {
      static void Main(string[] args)
      {
         Context context = new Context();
         context.SetStrategy(new StrategyA());
         context.DoSomeBusinesslogic();
         context.SetStrategy(new StrategyB());
         context.DoSomeBusinesslogic();
         context.SetStrategy(new StrategyC());
         context.DoSomeBusinesslogic();
         Console.ReadLine();
      }
   }
}
