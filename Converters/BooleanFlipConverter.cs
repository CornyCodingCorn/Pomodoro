using System;
using System.Globalization;
using Avalonia.Data.Converters;

namespace Pomodoro.Converters;

public class BooleanFlipConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is bool b) return !b;
        throw new Exception("Value is not of type bool");
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is bool b) return !b;
        throw new Exception("Value is not of type bool");
    }
}