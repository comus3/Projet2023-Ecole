using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;

namespace schoolManager.ViewModels;

internal class FirstViewModel
{
    public string Title => AppInfo.Name; 
    public string Version => AppInfo.VersionString;
    public string MoreInfoUrl => "https://aka.ms/maui";
    public string Message => "This app is written in XAML and C# with .NET MAUI.";
    public ICommand ShowMoreInfoCommand { get; }

    public FirstViewModel()
    {
        ShowMoreInfoCommand = new AsyncRelayCommand(ShowMoreInfo);
    }

    async Task ShowMoreInfo() =>
        await Launcher.Default.OpenAsync(MoreInfoUrl);
}

