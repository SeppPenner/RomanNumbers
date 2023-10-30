// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Hämmer Electronics">
//   Copyright (c) All rights reserved.
// </copyright>
// <summary>
//   The main program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace RomanNumbers.Test;

/// <summary>
/// The main program.
/// </summary>
public class Program
{
    /// <summary>
    /// The main method.
    /// </summary>
    public static void Main()
    {
        _ = BenchmarkRunner.Run<RomanBenchmark>();
    }
}
