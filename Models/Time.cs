using Avalonia.Data.Converters;

namespace Pomodoro.Models;

public struct Time
{
    public uint Hour { get; set; }
    public uint Minute { get; set; }
    public uint Second { get; set; }

    public bool IsValid()
    {
        return Hour is < 25 and > 0 && Minute is < 61 and > 0 && Second is < 61 and > 0;
    }
}