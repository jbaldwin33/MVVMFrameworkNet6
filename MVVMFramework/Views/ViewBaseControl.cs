using System;
using System.Windows;
using System.Windows.Controls;
using MVVMFramework.ViewModels;

namespace MVVMFramework.Views
{
    public abstract class ViewBaseControl : UserControl
    {
        private ViewModel viewModel;
        public event EventHandler OnLoadedHandler;
        public event EventHandler OnUnloadedHandler;

        public ViewBaseControl(ViewModel viewModel) : this()
        {
            this.viewModel = viewModel;
            DataContext = viewModel;
            Loaded += ViewBaseControl_Loaded;
            Unloaded += ViewBaseControl_Unloaded;
        }

        public virtual void ViewBaseControl_Loaded(object sender, RoutedEventArgs e)
        {
            viewModel.IsShown = true;
            viewModel.ShowMessageBoxEventHandler += ViewModel_ShowMessageBoxEventHandler;
            viewModel.OnLoaded();
            //OnLoadedHandler?.Invoke(this, EventArgs.Empty);
        }

        public virtual void ViewBaseControl_Unloaded(object sender, RoutedEventArgs e)
        {
            viewModel.IsShown = false;
            viewModel.ShowMessageBoxEventHandler -= ViewModel_ShowMessageBoxEventHandler;
            Loaded -= ViewBaseControl_Loaded;
            Unloaded -= ViewBaseControl_Unloaded;
            viewModel.OnUnloaded();
            //OnUnloadedHandler?.Invoke(this, EventArgs.Empty);
        }

        public ViewBaseControl()
        {
            
        }

        private void ViewModel_ShowMessageBoxEventHandler(object sender, MessageBoxEventArgs e) 
            => e.Result = Application.Current.Dispatcher.Invoke(() => MessageBox.Show(Application.Current.MainWindow, e.Message, e.MessageType.ToString(), e.Button, e.Image));
    }
}
