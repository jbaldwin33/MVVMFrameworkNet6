using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using MVVMFramework.ViewModels;
using MVVMFramework.Views;
using Application = System.Windows.Application;

namespace MVVMFramework.ViewNavigator
{
    public enum ViewType
    {
        Splitter,
        Converter
    }

    public interface INavigator
    {
        List<ViewModel> ViewModels { get; set; }
        ViewModel CurrentViewModel { get; set; }
        ViewModel ChildViewModel { get; set; }
        Window ChildView { get; set; }
        ICommand UpdateCurrentViewModelCommand { get; }
        ICommand OpenChildWindow { get; }
        ICommand CloseChildWindow { get; }
        void SetChildViewShown(bool shown);
    }

    public class Navigator : INavigator, INotifyPropertyChanged
    {
        private static readonly Lazy<Navigator> instance = new Lazy<Navigator>(() => new Navigator());
        public static Navigator Instance => instance.Value;
        private List<ViewModel> viewModels = new List<ViewModel>();
        private ViewModel currentViewModel;
        private ViewModel childViewModel;
        private bool childViewShown;
        private Window childView;


        public Navigator()
        {
            
        }

        #region Properties

        public List<ViewModel> ViewModels
        {
            get => viewModels;
            set
            {
                viewModels = value;
                OnPropertyChanged(nameof(ViewModels));
            }
        }

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
        public ICommand OpenChildWindow => new OpenChildWindowCommand(this);
        public ICommand CloseChildWindow => new CloseChildWindowCommand(this);

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

        public bool CanExecute(object parameter) => parameter is ViewModel vm && !vm.IsShown;

        public void Execute(object parameter)
        {
            if (!(parameter is ViewModel vm))
                throw new NotSupportedException();

            if (vm == navigator.CurrentViewModel)
                return;

            navigator.CurrentViewModel = vm;
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }

    public class OpenChildWindowCommand : ICommand
    {

        public event EventHandler CanExecuteChanged;
        private INavigator navigator;

        public OpenChildWindowCommand(INavigator navigator)
        {
            this.navigator = navigator;
        }

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            navigator.ChildView = new PopupWindowView
            {
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                contentControl = { Content = parameter as ViewModel },
                WindowStyle = WindowStyle.None
            };
            navigator.ChildViewModel = parameter as ViewModel;
            navigator.SetChildViewShown(true);
            navigator.ChildView.Owner = Application.Current.MainWindow;
            navigator.ChildView.ShowDialog();
        }
    }

    public class CloseChildWindowCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private INavigator navigator;

        public CloseChildWindowCommand(INavigator navigator)
        {
            this.navigator = navigator;
        }

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            navigator.ChildViewModel = null;
            navigator.SetChildViewShown(false);
            Application.Current.Dispatcher.Invoke(() => navigator.ChildView.Close());
        }
    }
}