// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RomanNumbersStupid.cs" company="Hämmer Electronics">
//   Copyright (c) All rights reserved.
// </copyright>
// <summary>
//   A (quite) stupid implementation of how to get Roman numbers from Arabic ones.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RomanNumbers;

/// <summary>
/// A (quite) stupid implementation of how to get Roman numbers from Arabic ones.
/// </summary>
public static class RomanNumbersStupid
{
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
        sb.Append(GetRomanNumber(number / 1000, DigitsType.Thousands));
        sb.Append(GetRomanNumber((number / 100) % 10, DigitsType.Hundreds));
        sb.Append(GetRomanNumber((number / 10) % 10, DigitsType.Tens));
        sb.Append(GetRomanNumber(number % 10, DigitsType.Ones));
        return sb.ToString().Trim();
    }

    /// <summary>
    /// Gets the Roman number.
    /// </summary>
    /// <param name="currentValue">The current digit.</param>
    /// <param name="digitsType">The digits type.</param>
    /// <returns>The Roman number.</returns>
    private static string GetRomanNumber(int currentValue, DigitsType digitsType)
    {
        return digitsType switch
        {
            DigitsType.Ones => GetRomanNumber(currentValue, 'I', 'V', 'X'),
            DigitsType.Tens => GetRomanNumber(currentValue, 'X', 'L', 'C'),
            DigitsType.Hundreds => GetRomanNumber(currentValue, 'C', 'D', 'M'),
            DigitsType.Thousands => GetRomanNumber(currentValue, 'M', ' ', ' '),
            _ => string.Empty,
        };
    }

    /// <summary>
    /// Gets the Roman number.
    /// </summary>
    /// <param name="currentValue">The current digit.</param>
    /// <param name="normalNumber">The normal number (e.g. I for 1).</param>
    /// <param name="fivesNumber">The fives number (e.g. V for 5).</param>
    /// <param name="tensNumber">The tens number (E.g. X for 10).</param>
    /// <returns>The Roman number.</returns>
    private static string GetRomanNumber(int currentValue, char normalNumber, char fivesNumber, char tensNumber)
    {
        switch (currentValue)
        {
            case <= 3:
                {
                    var sb = new StringBuilder();
                    var counter = 0;

                    while (counter < currentValue)
                    {
                        sb.Append(normalNumber);
                        counter++;
                    }

                    return sb.ToString();
                }
            case 4:
                return $"{normalNumber}{fivesNumber}";
            case 5:
                return fivesNumber.ToString();
            case > 5:
                {
                    if (currentValue < 9)
                    {
                        var sb = new StringBuilder();
                        sb.Append(fivesNumber);
                        var counter = 5;

                        while (counter < currentValue)
                        {
                            sb.Append(normalNumber);
                            counter++;
                        }

                        return sb.ToString();
                    }

                    return $"{normalNumber}{tensNumber}";
                }
        }
    }
}
