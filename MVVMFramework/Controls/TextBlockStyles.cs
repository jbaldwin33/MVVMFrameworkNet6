using System;
using System.Windows;
using System.Windows.Controls;

namespace MVVMFramework.Controls
{
    public class SmallTextBlock : TextBlock
    {
        public SmallTextBlock()
        {
            HorizontalAlignment = HorizontalAlignment.Center;
            Margin = new Thickness(5, 0, 5, 5);
            Width = 80;
            Height = 25;
            Padding = new Thickness(5, 5, 5, 5);
            FontSize = 15;
        }

        static SmallTextBlock()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SmallTextBlock), new FrameworkPropertyMetadata(typeof(SmallTextBlock)));
        }
    }

    public class MediumTextBlock : TextBlock
    {
        public MediumTextBlock()
        {
            HorizontalAlignment = HorizontalAlignment.Center;
            Margin = new Thickness(5, 0, 5, 5);
            Width = 120;
            Height = 25;
            Padding = new Thickness(5, 5, 5, 5);
            FontSize = 15;
        }

        static MediumTextBlock()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MediumTextBlock), new FrameworkPropertyMetadata(typeof(MediumTextBlock)));
        }
    }

    public class LargeTextBlock : TextBlock
    {
        public LargeTextBlock()
        {
            HorizontalAlignment = HorizontalAlignment.Center;
            Margin = new Thickness(5, 0, 5, 5);
            Width = 160;
            Height = 25;
            Padding = new Thickness(5, 5, 5, 5);
            FontSize = 15;
        }

        static LargeTextBlock()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LargeTextBlock), new FrameworkPropertyMetadata(typeof(LargeTextBlock)));
        }
    }
}
