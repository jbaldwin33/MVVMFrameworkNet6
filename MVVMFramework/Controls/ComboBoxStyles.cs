using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MVVMFramework.Controls
{
    public class ExtraSmallComboBox : ComboBox
    {
        public ExtraSmallComboBox()
        {
            HorizontalAlignment = HorizontalAlignment.Left;
            Margin = new Thickness(5, 0, 5, 5);
            Width = 50;
            Height = 25;
            Padding = new Thickness(5, 5, 5, 5);
        }

        static ExtraSmallComboBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ExtraSmallComboBox), new FrameworkPropertyMetadata(typeof(ExtraSmallComboBox)));
        }
    }

    public class SmallComboBox : ComboBox
    {
        public SmallComboBox()
        {
            HorizontalAlignment = HorizontalAlignment.Left;
            Margin = new Thickness(5, 0, 5, 5);
            Width = 75;
            Height = 25;
            Padding = new Thickness(5, 5, 5, 5);
        }

        static SmallComboBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SmallComboBox), new FrameworkPropertyMetadata(typeof(SmallComboBox)));
        }
    }

    public class MediumComboBox : ComboBox
    {
        public MediumComboBox()
        {
            HorizontalAlignment = HorizontalAlignment.Left;
            Margin = new Thickness(5, 0, 5, 5);
            Width = 100;
            Height = 25;
            Padding = new Thickness(5, 5, 5, 5);
        }

        static MediumComboBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MediumComboBox), new FrameworkPropertyMetadata(typeof(MediumComboBox)));
        }
    }

    public class LargeComboBox : ComboBox
    {
        public LargeComboBox()
        {
            HorizontalAlignment = HorizontalAlignment.Left;
            Margin = new Thickness(5, 0, 5, 5);
            Width = 125;
            Height = 25;
            Padding = new Thickness(5, 5, 5, 5);
        }

        static LargeComboBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LargeComboBox), new FrameworkPropertyMetadata(typeof(LargeComboBox)));
        }
    }

    public class ExtraLargeComboBox : ComboBox
    {
        public ExtraLargeComboBox()
        {
            HorizontalAlignment = HorizontalAlignment.Left;
            Margin = new Thickness(5, 0, 5, 5);
            Width = 150;
            Height = 25;
            Padding = new Thickness(5, 5, 5, 5);
        }

        static ExtraLargeComboBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ExtraLargeComboBox), new FrameworkPropertyMetadata(typeof(ExtraLargeComboBox)));
        }
    }
}
