using System;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Filters;
using BenchmarkDotNet.Running;

namespace BenchmarkDemo
{
  class Program
  {
    static void Main(string[] args)
    {
      BenchmarkRunner.Run<TestBenchmark>();
      Console.Read();
    }
  }
}
