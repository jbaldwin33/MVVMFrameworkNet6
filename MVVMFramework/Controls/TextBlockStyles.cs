using System;
using System.Windows;
using System.Windows.Controls;

namespace MVVMFramework.Controls
{
    public static class TextBlockUtilities
    {
        
    }

    public class DefaultTextBlock : TextBlock
    {
        public DefaultTextBlock()
        {
            HorizontalAlignment = HorizontalAlignment.Center;
            Margin = new Thickness(5, 0, 5, 5);
            Padding = new Thickness(5, 5, 5, 5);

        }

        static DefaultTextBlock()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DefaultTextBlock), new FrameworkPropertyMetadata(typeof(DefaultTextBlock)));
        }
    }
    public class SmallTextBlock : DefaultTextBlock
    {
        public SmallTextBlock()
        {
            Width = 80;
            Height = 25;
            FontSize = 15;
        }

        static SmallTextBlock()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SmallTextBlock), new FrameworkPropertyMetadata(typeof(SmallTextBlock)));
        }
    }

    public class MediumTextBlock : DefaultTextBlock
    {
        public MediumTextBlock()
        {
            Width = 120;
            Height = 25;
            FontSize = 15;
        }

        static MediumTextBlock()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MediumTextBlock), new FrameworkPropertyMetadata(typeof(MediumTextBlock)));
        }
    }

    public class LargeTextBlock : DefaultTextBlock
    {
        public LargeTextBlock()
        {
            Width = 160;
            Height = 25;
            FontSize = 15;
        }

        static LargeTextBlock()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LargeTextBlock), new FrameworkPropertyMetadata(typeof(LargeTextBlock)));
        }
    }
}
