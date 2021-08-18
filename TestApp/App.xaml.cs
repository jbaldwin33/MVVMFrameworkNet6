using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using MVVMFramework.Views;

namespace TestApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            //var window = new MainWindow(new TestViewModel());
            var window = new BaseWindowView(new[] { (typeof(TestViewModel), "Test") });
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Show();
            base.OnStartup(e);
        }
    }
}
