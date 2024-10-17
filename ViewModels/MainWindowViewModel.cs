using System;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Pomodoro.Models;

namespace Pomodoro.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private Time _countDownTime;
    [ObservableProperty]
    private bool _isRunning;
    
    public MainWindowViewModel()
    {
    }

    [RelayCommand]
    private void Edit()
    {
        IsRunning = !IsRunning;
        Console.WriteLine($"State: {(IsRunning ? "Running" : "Not Running")}");
    }
}
