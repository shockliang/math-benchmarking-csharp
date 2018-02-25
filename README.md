## Benchmarking for csharp Math object. ##

### Enviroment ###
``` ini

BenchmarkDotNet=v0.10.12, OS=macOS 10.12.6 (16G1212) [Darwin 16.7.0]
Intel Core i7-4770HQ CPU 2.20GHz (Haswell), 1 CPU, 8 logical cores and 4 physical cores
.NET Core SDK=2.0.3
  [Host]     : .NET Core 2.0.3 (Framework 4.6.0.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.3 (Framework 4.6.0.0), 64bit RyuJIT

```

### Report of square calculate ###
|                  Method |    N |         Mean |      Error |     StdDev |
|------------------------ |----- |-------------:|-----------:|-----------:|
|   **SquareUsingMathObject** |  **100** |  **3,387.95 ns** |  **67.037 ns** |  **68.842 ns** |
| SquareUsingSelfMultiply |  100 |     83.64 ns |   1.437 ns |   1.344 ns |
|   **SquareUsingMathObject** | **1000** | **35,210.07 ns** | **697.821 ns** | **955.185 ns** |
| SquareUsingSelfMultiply | 1000 |    699.53 ns |  14.103 ns |  15.090 ns |

### Report of power of two calculate ###
|                             Method |  N |       Mean |     Error |    StdDev |     Median |
|----------------------------------- |--- |-----------:|----------:|----------:|-----------:|
|          **PowerOfTwoUsingMathObject** |  **1** | **10.4050 ns** | **0.2384 ns** | **0.2745 ns** | **10.4271 ns** |
| IteratingPowerOfTwoUsingMathObject |  1 |  0.1815 ns | 0.0418 ns | 0.0448 ns |  0.1768 ns |
|             PowerOfTwoUsingBitwise |  1 |  0.0054 ns | 0.0083 ns | 0.0127 ns |  0.0000 ns |
|    IteratingPowerOfTwoUsingBitwise |  1 |  0.0293 ns | 0.0238 ns | 0.0398 ns |  0.0038 ns |
|          **PowerOfTwoUsingMathObject** | **32** |  **9.7972 ns** | **0.2087 ns** | **0.1743 ns** |  **9.7977 ns** |
| IteratingPowerOfTwoUsingMathObject | 32 | 13.8069 ns | 0.3106 ns | 0.4354 ns | 13.7526 ns |
|             PowerOfTwoUsingBitwise | 32 |  0.0016 ns | 0.0045 ns | 0.0042 ns |  0.0000 ns |
|    IteratingPowerOfTwoUsingBitwise | 32 | 15.0144 ns | 0.3261 ns | 0.3489 ns | 14.9654 ns |
|          **PowerOfTwoUsingMathObject** | **64** | **10.0087 ns** | **0.2282 ns** | **0.2135 ns** |  **9.9869 ns** |
| IteratingPowerOfTwoUsingMathObject | 64 | 32.2433 ns | 0.6789 ns | 0.7264 ns | 32.2171 ns |
|             PowerOfTwoUsingBitwise | 64 |  0.0014 ns | 0.0045 ns | 0.0042 ns |  0.0000 ns |
|    IteratingPowerOfTwoUsingBitwise | 64 | 32.1986 ns | 0.6799 ns | 0.7830 ns | 32.0350 ns |
