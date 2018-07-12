using System.ComponentModel;

namespace SCV.UTL
{
    public abstract class ObservableObject: INotifyPropertyChanged
    {
        
        public event PropertyChangedEventHandler PropertyChanged;

        
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;

            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }
    }
}
