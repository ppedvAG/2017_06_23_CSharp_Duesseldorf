using System.Windows.Input;

namespace HalloMVVM.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {
        private string _welcomeText = "Hallo MVVM.";
        public string WelcomeText
        {
            get { return _welcomeText; }
            set
            {
                _welcomeText = value;
                RaisePropertyChanged();
            }
        }

        private ICommand _changeTextCommand;
        public ICommand ChangeTextCommand
        {
            get
            {
                return _changeTextCommand ??
                  (_changeTextCommand = new RelayCommand(
                      execute: () => WelcomeText = "Der neue Text aus dem Command!",
                      canExecute: () => WelcomeText.Length < 10));
            }
        }
    }
}
