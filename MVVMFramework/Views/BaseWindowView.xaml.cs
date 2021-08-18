using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using MVVMFramework.Controls;
using MVVMFramework.Utilities;
using MVVMFramework.ViewModels;
using MVVMFramework.ViewNavigator;

namespace MVVMFramework.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class BaseWindowView : ViewBase
    {
        public BaseWindowView((Type, string)[] viewModelTypes) : base(new MainViewModel(Navigator.Instance))
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            if (viewModelTypes == null || viewModelTypes.Length == 0)
                throw new ArgumentNullException(nameof(viewModelTypes));

            InitializeComponent();
            foreach (var (type, name) in viewModelTypes)
            {
                var instance = (ViewModel)Activator.CreateInstance(type);
                if (Navigator.Instance.CurrentViewModel == null)
                    Navigator.Instance.CurrentViewModel = instance;

                Navigator.Instance.ViewModels.Add(instance);
                var button = new SmallButton
                {
                    CommandParameter = instance,
                    Content = name,
                    Command = Navigator.Instance.UpdateCurrentViewModelCommand,
                };
                var binding = new Binding("IsShown")
                {
                    Mode = BindingMode.TwoWay, 
                    UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged, 
                    Converter = new InverseBooleanConverter(),
                    Source = Navigator.Instance.ViewModels.FirstOrDefault(vm => vm.GetType() == type)
                };
                
                button.SetBinding(IsEnabledProperty, binding);
                navigationBar.stackPanel.Children.Add(button);
            }
        }

        protected override void BeforeShow(object sender, RoutedEventArgs e) { }

        protected override void AfterShow(object sender, EventArgs e) { }

        protected override void OnClosing(object sender, CancelEventArgs e) { }

        protected override void OnClosed(object sender, EventArgs e) { }
    }
}
