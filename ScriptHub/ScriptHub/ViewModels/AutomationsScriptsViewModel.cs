using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ScriptHub.ViewModels
{
    public partial class AutomationsScriptsViewModel : ObservableObject
    {
        [RelayCommand]
        private async Task GoToMainPage()
        {
            await Shell.Current.GoToAsync("///MainPage");
        }
    }
}
