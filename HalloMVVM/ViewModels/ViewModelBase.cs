using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HalloMVVM.ViewModels
{
    internal abstract class ViewModelBase : INotifyPropertyChanged
    {
        protected void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            // if (PropertyChanged != null)
            //      PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
