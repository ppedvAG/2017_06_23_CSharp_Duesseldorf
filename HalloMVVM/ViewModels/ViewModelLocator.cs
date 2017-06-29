namespace HalloMVVM.ViewModels
{
    internal class ViewModelLocator
    {
        public MainWindowViewModel Main { get; }

        public ViewModelLocator()
        {
            Main = new MainWindowViewModel();
        }
    }
}
