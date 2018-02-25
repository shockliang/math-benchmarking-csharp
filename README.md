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