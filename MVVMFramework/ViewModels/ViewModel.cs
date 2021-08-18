using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace MVVMFramework.ViewModels
{
    public abstract class ViewModel : INotifyPropertyChanged
    {
        private bool isShown;

        public bool IsShown
        {
            get => isShown;
            set => SetProperty(ref isShown, value);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler<MessageBoxEventArgs> ShowMessageBoxEventHandler;
        
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        protected bool SetProperty<T>(ref T fieldReference, T newValue, string propertyName = null)
        {
            var valueIsEqual = Equals(fieldReference, newValue);
            if (valueIsEqual)
                return false;

            fieldReference = newValue;
            OnPropertyChanged(propertyName);
            return true;
        }

        protected void ShowMessage(MessageBoxEventArgs e) => ShowMessageBoxEventHandler?.Invoke(this, e);
    }

    public class MessageBoxEventArgs : EventArgs
    {
        public string Message { get; set; }
        public string Caption { get; set; }
        public MessageBoxButton Button { get; set; }
        public MessageBoxImage Image { get; set; }
        public MessageBoxResult Result { get; set; }

        public MessageBoxEventArgs(string message, string caption, MessageBoxButton button, MessageBoxImage image)
        {
            Message = message;
            Caption = caption;
            Button = button;
            Image = image;
        }
    }
}
