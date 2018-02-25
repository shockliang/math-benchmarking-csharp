using System;
using BenchmarkDotNet.Attributes;

namespace math_benchmarking_csharp
{
    public class PowerOfTwoBenchmarking
    {
        [Params(1, 32, 64)]
        public int N;

        // private readonly int RUN_COUNT = 10000;

        [Benchmark]
        public void PowerOfTwoUsingMathObject()
        {
            var result = Math.Pow(2, N);
        }

        [Benchmark]
        public void IteratingPowerOfTwoUsingMathObject()
        {
            for (int i = 0; i < N; i++)
            {
                var result = Math.Pow(2, i);
            }
        }

        [Benchmark]
        public void PowerOfTwoUsingBitwise()
        {
            var result = (ulong)1 << (N);
        }

        [Benchmark]
        public void IteratingPowerOfTwoUsingBitwise()
        {
            for (int i = 0; i < N; i++)
            {
                var result = (ulong)1 << i;
            }
        }
    }
}