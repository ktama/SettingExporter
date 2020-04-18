using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DataType
{
    public abstract class BaseDataType : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Hint { get; set; } = string.Empty;
    }
}
