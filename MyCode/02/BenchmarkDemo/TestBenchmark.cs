using System;
using BenchmarkDotNet.Attributes;

public class TestBenchmark
{

  [Params(10, 20, 30)]
  public int Len { get; set; }

  [Benchmark]
  public void Fibonacci()
  {
    int a = 0, b = 1, c = 0;
    Console.Write("{0} {1}", a, b);

    for (int i = 2; i < Len; i++)
    {
      c = a + b;
      Console.Write(" {0}", c);
      a = b;
      b = c;
    }
  }

  [Benchmark]
  public void FibonacciRecursive()
  {

    Fibonacci_Recursive(0, 1, 1, Len);
  }

  private void Fibonacci_Recursive(int a, int b, int counter, int len)
  {
    if (counter <= len)
    {
      Console.Write("{0} ", a);
      Fibonacci_Recursive(b, a + b, counter + 1, len);
    }
  }
}
