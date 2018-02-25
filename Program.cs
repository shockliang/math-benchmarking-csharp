using System;
using BenchmarkDotNet.Running;

namespace math_benchmarking_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // var switcher = new BenchmarkSwitcher(new[] {
            //     typeof(SquareBenchmarking),
            //     typeof(PowerOfTwoBenchmarking),
            // });
            // switcher.Run(args);
            BenchmarkRunner.Run<SquareBenchmarking>();
            BenchmarkRunner.Run<PowerOfTwoBenchmarking>();
        }
    }
}
