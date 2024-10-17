using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;

namespace Pomodoro.Controllers;

public partial class EditableTextBlock : UserControl
{
    public static readonly StyledProperty<string> TextProperty = AvaloniaProperty.Register<EditableTextBlock, string>(nameof(Text), defaultValue: string.Empty);
    public static readonly StyledProperty<bool> IsEditingProperty = AvaloniaProperty.Register<EditableTextBlock, bool>(nameof(IsEditing));
    
    public string Text
    {
        get => GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    public bool IsEditing
    {
        get => GetValue(IsEditingProperty);
        set
        {
            SetValue(IsEditingProperty, value);
            Console.WriteLine($"Value changed to {IsEditing}");
        }
    }
    
    public EditableTextBlock()
    {
        InitializeComponent();
    }
}