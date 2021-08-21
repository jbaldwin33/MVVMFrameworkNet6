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
            var types = new[]
            {
                (typeof(TestViewModel), "Change Speed"),
                (typeof(TestViewModel), "Change Speed"),
                (typeof(TestViewModel), "Change Speed"),
                (typeof(TestViewModel), "Change Speed"),
                (typeof(TestViewModel), "Change Speed"),
            };
            var window = new BaseWindowView(types);
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Show();
            base.OnStartup(e);
        }
    }
}
