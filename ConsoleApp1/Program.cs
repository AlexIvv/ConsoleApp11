using System;

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {
      
    }
    static int FibonachiCicle(int Index)
    {
      int x1 = 0, x2 = 1, y = x1 + x2;
      if (Index < 0)
      {
        Console.WriteLine("Error:number is negative");
        return -1;
      }
      else if (Index == 0)
      {
        return x1;
      }
      else if (Index == 1)
      {
        return x2;
      }
      else
      {
        for (int i = 2; i <= Index; i++)
        {
          y = x1 + x2;
          x1 = x2;
          x2 = y;

        }
        Console.WriteLine();
        return y;
      }
    }
    static int IndexOfMemberFibonachi(int FibonachiMember){
      int a = 0;
      int b = 1;
      return 0;
    }
  }
}
