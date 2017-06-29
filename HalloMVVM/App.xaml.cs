using System.Windows;

namespace HalloMVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Durch den ViewModelLocator kann man Steuerne wie viele ViewModels es gibt.
            //for (int i = 0; i < 10; i++)
            //{
            //    new Views.MainWindow().Show();
            //}
        }
    }
}
