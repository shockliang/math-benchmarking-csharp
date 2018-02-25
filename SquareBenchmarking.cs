using System;
using BenchmarkDotNet.Attributes;

namespace math_benchmarking_csharp
{
    public class SquareBenchmarking
    {
        [Params(1000, 10000)]
        public int N;

        [Benchmark]
        public void SquareUsingMathObject()
        {
            for (int i = 0; i < N; i++)
            {
                var result = Convert.ToUInt64(Math.Pow(i, 2));
            }
        }

        [Benchmark]
        public void SquareUsingSelfMultiply()
        {
            for (int i = 0; i < N; i++)
            {
                var result = Convert.ToUInt64(i.Square());
            }
        }
    }
}