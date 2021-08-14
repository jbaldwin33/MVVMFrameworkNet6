using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows.Data;
using MVVMFramework.ViewModels;
using MVVMFramework.Views;

namespace MVVMFramework.ViewNavigator
{
    public enum ViewType
    {
        Splitter,
        Converter
    }

    public interface INavigator
    {
        ViewModel CurrentViewModel { get; set; }
        ViewModel ChildViewModel { get; set; }
        ICommand UpdateCurrentViewModelCommand { get; }
        ICommand OpenChildWindow { get; }
        ICommand CloseChildWindow { get; }
        void SetChildViewShown(bool shown);
    }

    public class Navigator : INavigator, INotifyPropertyChanged
    {
        private static readonly Lazy<Navigator> instance = new Lazy<Navigator>(() => new Navigator());
        public static Navigator Instance => instance.Value;

        private ViewModel currentViewModel;
        private ViewModel childViewModel;
        private bool childViewShown;
        private Window childView;


        public Navigator()
        {
            
        }

        #region Properties

        public ViewModel CurrentViewModel
        {
            get => currentViewModel;
            set
            {
                currentViewModel = value;
                OnPropertyChanged(nameof(CurrentViewModel));
            }
        }

        public ViewModel ChildViewModel
        {
            get => childViewModel;
            set
            {
                childViewModel = value;
                OnPropertyChanged(nameof(ChildViewModel));
            }
        }

        public Window ChildView
        {
            get => childView;
            set
            {
                childView = value;
                OnPropertyChanged(nameof(ChildView));
            }
        }

        public bool ChildViewShown
        {
            get => childViewShown;
            set
            {
                childViewShown = value;
                OnPropertyChanged(nameof(ChildViewShown));
            }
        }

        #endregion

        public void SetChildViewShown(bool shown) => ChildViewShown = shown;

        public ICommand UpdateCurrentViewModelCommand => new UpdateCurrentViewModelCommand(this);
        public ICommand OpenChildWindow => new OpenChildWindowCommand();
        public ICommand CloseChildWindow => new CloseChildWindowCommand();

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public class UpdateCurrentViewModelCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private INavigator navigator;

        public UpdateCurrentViewModelCommand(INavigator navigator)
        {
            this.navigator = navigator;
        }

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            var type = parameter as Type;
            if (type?.BaseType == typeof(ViewModel))
            {
                var instance = Activator.CreateInstance(type);
                navigator.CurrentViewModel = (ViewModel)instance;
            }
            else
                throw new NotSupportedException();
        }
    }

    public class OpenChildWindowCommand : ICommand
    {

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            Navigator.Instance.ChildView = new PopupWindowView
            {
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                contentControl = { Content = parameter as ViewModel }
            };
            Navigator.Instance.ChildViewModel = parameter as ViewModel;
            Navigator.Instance.SetChildViewShown(true);
            Navigator.Instance.ChildView.Owner = Application.Current.MainWindow;
            Navigator.Instance.ChildView.Show();
        }
    }

    public class CloseChildWindowCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            Navigator.Instance.ChildViewModel = null;
            Navigator.Instance.SetChildViewShown(false);
            Application.Current.Dispatcher.Invoke(() => Navigator.Instance.ChildView.Close());
        }
    }
}