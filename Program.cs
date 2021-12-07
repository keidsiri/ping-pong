using System;
using System.Collections.Generic;

namespace Interface 
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Input a number!");
      string stringNumber = Console.ReadLine();
      int intNumber = int.Parse(stringNumber);

      for (int i = 1 ; i <= intNumber ; i++)
      {
        if ( i % 3 == 0  && i % 5 == 0)
        {
          Console.WriteLine("ping-pong");
        }
        else if ( i % 3 == 0)
        {
          Console.WriteLine("ping");
        }
        else if (i % 5 == 0)
        {
          Console.WriteLine("pong");
        }
        else
        {
          Console.WriteLine(i);
        }
      }
    }
  }
}
