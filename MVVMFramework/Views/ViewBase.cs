using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVMFramework.Views
{
    public abstract class ViewBase : Window
    {
        public ViewBase()
        {
            Loaded += BeforeShow;
            ContentRendered += AfterShow;
            Closing += OnClosing;
            Closed += OnClosed;
        }

        protected abstract void BeforeShow(object sender, RoutedEventArgs e);
        protected abstract void AfterShow(object sender, EventArgs e);
        protected abstract void OnClosing(object sender, CancelEventArgs e);
        protected abstract void OnClosed(object sender, EventArgs e);
    }
}
