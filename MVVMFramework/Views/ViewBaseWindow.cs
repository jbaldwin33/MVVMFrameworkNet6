using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MVVMFramework.ViewModels;

namespace MVVMFramework.Views
{
    public abstract class ViewBaseWindow : Window
    {
        public ViewBaseWindow(ViewModel viewModel)
        {
            DataContext = viewModel;
            Loaded += BeforeShow;
            ContentRendered += AfterShow;
            Closing += OnClosing;
            Closed += OnClosed;
            Style = Resources["StandardStyle"] as Style;
        }

        protected virtual void BeforeShow(object sender, RoutedEventArgs e) => throw new NotImplementedException();
        protected virtual void AfterShow(object sender, EventArgs e) => throw new NotImplementedException();
        protected virtual void OnClosing(object sender, CancelEventArgs e) => throw new NotImplementedException();
        protected virtual void OnClosed(object sender, EventArgs e) => throw new NotImplementedException();
    }
}
