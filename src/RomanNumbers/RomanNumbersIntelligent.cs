// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RomanNumbersIntelligent.cs" company="Hämmer Electronics">
//   Copyright (c) All rights reserved.
// </copyright>
// <summary>
//   A more intelligent implementation of how to get Roman numbers from Arabic ones.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RomanNumbers;

/// <summary>
/// A more intelligent implementation of how to get Roman numbers from Arabic ones.
/// </summary>
public static class RomanNumbersIntelligent
{
    /// <summary>
    /// The thousands.
    /// </summary>
    private static readonly string[] Thousands = new[] { string.Empty, "M", "MM", "MMM" };

    /// <summary>
    /// The hundreds.
    /// </summary>
    private static readonly string[] Hundreds = new[] { string.Empty, "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };

    /// <summary>
    /// The tens.
    /// </summary>
    private static readonly string[] Tens = new[] { string.Empty, "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "LC" };

    /// <summary>
    /// The ones.
    /// </summary>
    private static readonly string[] Ones = new[] { string.Empty, "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

    /// <summary>
    /// Gets the Roman number.
    /// </summary>
    /// <param name="number"> The number.</param>
    /// <exception cref="InvalidOperationException">Thrown if the number is less than 1 or bigger than 3999.</exception>
    /// <returns>The Roman number.</returns>
    public static string GetRomanNumber(int number)
    {
        if (number < 1 || number > 3999)
        {
            throw new InvalidOperationException("The number is not in the range of 1 to 3999");
        }

        var sb = new StringBuilder();
        sb.Append(Thousands[number / 1000]);
        sb.Append(Hundreds[(number / 100) % 10]);
        sb.Append(Tens[(number / 10) % 10]);
        sb.Append(Ones[number % 10]);
        return sb.ToString();
    }
}
