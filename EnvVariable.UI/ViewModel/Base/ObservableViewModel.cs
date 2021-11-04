using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EnvVariable.UI.ViewModel
{
    public abstract class ObservableViewModel : INotifyPropertyChanged
    {
        protected ObservableViewModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
