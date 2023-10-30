// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RomanBenchmark.cs" company="Hämmer Electronics">
//   Copyright (c) All rights reserved.
// </copyright>
// <summary>
//   The Roman numbers benchmark.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RomanNumbers.Test;

/// <summary>
/// The Roman numbers benchmark.
/// </summary>
[SimpleJob(RuntimeMoniker.Net70)]
[RPlotExporter]
public class RomanBenchmark
{
    /// <summary>
    /// The number given to the tests.
    /// </summary>
    [Params(1, 5, 7, 9, 145, 167, 546, 1201, 1874, 2579, 3399, 3999)]
    public int Number;

    /// <summary>
    /// Runs the intelligent Roman number function.
    /// </summary>
    /// <returns>The found Roman number.</returns>
    [Benchmark]
    public string RunRomanNumbersIntelligent() => RomanNumbersIntelligent.GetRomanNumber(this.Number);

    /// <summary>
    /// Runs the stuip Roman number function.
    /// </summary>
    /// <returns>The found Roman number.</returns>
    [Benchmark]
    public string RunRomanNumbersStupid() => RomanNumbersStupid.GetRomanNumber(this.Number);
}
