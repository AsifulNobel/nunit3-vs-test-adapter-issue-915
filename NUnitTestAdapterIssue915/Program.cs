using System;

namespace NUnitTestAdapterIssue915v2
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }

  public class Adder
  {
    public int Add3(int input) =>
      input + 3;

    public int Add5(int input) =>
      input + 5;

    public int Add7(int input) =>
      input + 7;
  }
}
