```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 10 (10.0.19045.3570/22H2/2022Update)
AMD Ryzen 9 3950X, 1 CPU, 32 logical and 16 physical cores
.NET SDK 7.0.400
  [Host]   : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2 [AttachedDebugger]
  .NET 7.0 : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2

Job=.NET 7.0  Runtime=.NET 7.0  

```
| Method                     | Number | Mean      | Error    | StdDev   | Median    |
|--------------------------- |------- |----------:|---------:|---------:|----------:|
| **RunRomanNumbersIntelligent** | **1**      |  **27.47 ns** | **0.580 ns** | **0.543 ns** |  **27.50 ns** |
| RunRomanNumbersStupid      | 1      |  95.69 ns | 1.889 ns | 1.767 ns |  95.46 ns |
| **RunRomanNumbersIntelligent** | **5**      |  **26.24 ns** | **0.386 ns** | **0.342 ns** |  **26.09 ns** |
| RunRomanNumbersStupid      | 5      |  75.31 ns | 1.313 ns | 1.097 ns |  75.26 ns |
| **RunRomanNumbersIntelligent** | **7**      |  **27.89 ns** | **0.580 ns** | **0.515 ns** |  **27.75 ns** |
| RunRomanNumbersStupid      | 7      |  97.97 ns | 1.386 ns | 1.296 ns |  98.44 ns |
| **RunRomanNumbersIntelligent** | **9**      |  **27.02 ns** | **0.298 ns** | **0.233 ns** |  **26.97 ns** |
| RunRomanNumbersStupid      | 9      | 111.62 ns | 0.714 ns | 0.596 ns | 111.68 ns |
| **RunRomanNumbersIntelligent** | **145**    |  **29.57 ns** | **0.560 ns** | **0.666 ns** |  **29.36 ns** |
| RunRomanNumbersStupid      | 145    | 124.60 ns | 1.891 ns | 3.211 ns | 124.10 ns |
| **RunRomanNumbersIntelligent** | **167**    |  **30.02 ns** | **0.307 ns** | **0.240 ns** |  **30.02 ns** |
| RunRomanNumbersStupid      | 167    | 118.10 ns | 1.036 ns | 0.809 ns | 118.02 ns |
| **RunRomanNumbersIntelligent** | **546**    |  **28.45 ns** | **0.465 ns** | **0.363 ns** |  **28.35 ns** |
| RunRomanNumbersStupid      | 546    | 120.96 ns | 2.436 ns | 3.863 ns | 118.96 ns |
| **RunRomanNumbersIntelligent** | **1201**   |  **28.39 ns** | **0.619 ns** | **0.688 ns** |  **28.13 ns** |
| RunRomanNumbersStupid      | 1201   | 113.25 ns | 2.207 ns | 2.627 ns | 113.65 ns |
| **RunRomanNumbersIntelligent** | **1874**   |  **35.56 ns** | **0.479 ns** | **0.448 ns** |  **35.55 ns** |
| RunRomanNumbersStupid      | 1874   | 161.31 ns | 3.174 ns | 3.117 ns | 160.60 ns |
| **RunRomanNumbersIntelligent** | **2579**   |  **32.18 ns** | **0.619 ns** | **0.908 ns** |  **31.70 ns** |
| RunRomanNumbersStupid      | 2579   | 136.16 ns | 2.298 ns | 2.150 ns | 136.67 ns |
| **RunRomanNumbersIntelligent** | **3399**   |  **34.63 ns** | **0.693 ns** | **0.614 ns** |  **34.74 ns** |
| RunRomanNumbersStupid      | 3399   | 165.87 ns | 2.173 ns | 2.032 ns | 165.77 ns |
| **RunRomanNumbersIntelligent** | **3999**   |  **33.33 ns** | **0.647 ns** | **0.573 ns** |  **33.37 ns** |
| RunRomanNumbersStupid      | 3999   | 186.44 ns | 1.316 ns | 1.099 ns | 186.15 ns |
