using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using static MVVMFramework.Controls.ControlUtilities;

namespace MVVMFramework.Controls
{
    public class DefaultStackPanel : StackPanel
    {
        public DefaultStackPanel()
        {
            Orientation = Orientation.Vertical;
            HorizontalAlignment = HorizontalAlignment.Left;
            VerticalAlignment = VerticalAlignment.Top;
            Margin = new Thickness(10);
        }

        static DefaultStackPanel()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DefaultStackPanel), new FrameworkPropertyMetadata(typeof(DefaultStackPanel)));
        }
    }

    public class DefaultCheckBox : CheckBox
    {
        public DefaultCheckBox()
        {
            Template = SetTemplateContent<DefaultCheckBox>();
            Margin = new Thickness(10);
        }

        static DefaultCheckBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DefaultCheckBox), new FrameworkPropertyMetadata(typeof(DefaultCheckBox)));
        }
    }
}
