using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using MVVMFramework.Localization;
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
            //TranslatableClass.Instance.CurrentCultureInfo = CultureInfo.GetCultureInfo("ja-JP");
            var types = new[]
            {
                (typeof(TestViewModel), "Change Speed"),
                (typeof(TestViewModel), "Change Speed"),
                (typeof(TestViewModel), "Change Speed"),
                (typeof(TestViewModel), "Change Speed"),
                (typeof(TestViewModel), new SplitterTranslatable()),
            };
            var window = new BaseWindowView(types);
            //var window = new NewWindow();
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Show();
            base.OnStartup(e);
        }

        private void BtnClose_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnRestore_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
