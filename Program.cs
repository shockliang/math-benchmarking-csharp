using System;
using BenchmarkDotNet.Running;

namespace math_benchmarking_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<SquareBenchmarking>();
        }
    }
}
