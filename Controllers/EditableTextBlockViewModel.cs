using CommunityToolkit.Mvvm.ComponentModel;

namespace Pomodoro.Controllers;

public partial class EditableTextBlockViewModel : ObservableObject
{
    [ObservableProperty] private string _text;
    [ObservableProperty] private bool _isEditing;
}