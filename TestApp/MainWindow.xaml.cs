using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MVVMFramework.ViewModels;
using MVVMFramework.Views;
using ViewBase = MVVMFramework.Views.ViewBase;

namespace TestApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ViewBase
    {
        private TestViewModel vm;
        public MainWindow(TestViewModel testViewModel)
        {
            InitializeComponent();
            DataContext = testViewModel;
            vm = testViewModel;
            vm.ShowMessageBoxEventHandler += Vm_ShowMessageBoxEventHandler;

        }

        protected override void BeforeShow(object sender, RoutedEventArgs e)
        {
            
        }

        protected override void AfterShow(object sender, EventArgs e)
        {
            vm.wait(3000);
            vm.MyBool = true;
        }

        protected override void OnClosing(object sender, CancelEventArgs e)
        {
            
        }

        protected override void OnClosed(object sender, EventArgs e)
        {
            
        }


        private void Vm_ShowMessageBoxEventHandler(object sender, MessageBoxEventArgs e)
        {
            MessageBox.Show(e.Message, e.Caption, e.Button, e.Image);
        }
    }
}
