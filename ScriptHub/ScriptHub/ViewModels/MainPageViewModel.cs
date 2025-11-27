using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ScriptHub.Views;
using System.Collections.ObjectModel;

namespace ScriptHub.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        [RelayCommand]
        private async Task GoToAutomationsScriptsPage()
        {
            await Shell.Current.GoToAsync("///AutomationsScriptsPage");
        }

        [RelayCommand]
        private async Task GoToConvertersScriptsPage()
        {
            await Shell.Current.GoToAsync("///ConvertersScriptsPage");
        }

        [RelayCommand]
        private async Task GoToVerificationsScriptsPage()
        {
            await Shell.Current.GoToAsync("///VerificationsScriptsPage");
        }
    }
}
