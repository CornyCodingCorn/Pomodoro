using System;
using System.Globalization;
using Avalonia.Data.Converters;
using Pomodoro.Models;

namespace Pomodoro.Converters;

public class TimeToStringConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (targetType != typeof(string))
            throw new Exception("Target must be a string");
        
        if (value?.GetType() != typeof(Time))
            throw new Exception("Value must be a Time");

        var time = (Time)value;
        return $"{time.Hour:D2}:{time.Minute:D2}:{time.Second:D2}";
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}